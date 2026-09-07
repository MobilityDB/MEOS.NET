#!/usr/bin/env python3
"""The record of what the generators could not read out of the MEOS API catalog.

A binding is a projection of the catalog, so every fact the emitted surface
states has to come from there.  Where the catalog does not state one, the
generator has two honest answers and no third: emit the surface without the fact
and say so here, or emit nothing where the shape cannot be expressed at all and
say that here.  It never picks the likely answer, because a guessed contract is
indistinguishable from a derived one once it sits in the emitted code, and it
never reads the answer out of a sibling binding, whose own answer was derived
from a catalog nobody can date.

The silence is the failure this file exists to remove.  A fall-through that
emits a weaker wrapper and records nothing leaves a reader of the surface unable
to tell a derived contract from an absent one, so every site a generator falls
through is registered here whether or not it fires — a kind with no rows still
prints, which is what makes an empty section evidence rather than an omission.

Both generators write into ``GAP-LEDGER.md``: ``tools/codegen.py`` owns the flat
surface's section and ``tools/objectgen.py`` the object layer's, each rewriting
only its own, so running one leaves the other's account standing.
"""

from __future__ import annotations

import re
from pathlib import Path

LEDGER_FILE = "GAP-LEDGER.md"

SECTIONS = ("flat surface", "object layer")

_PREAMBLE = """\
# Gap ledger

Every contract the MEOS.NET generators need and the MEOS API catalog does not
state.  Two kinds of row: a CONTRACT the surface is emitted without, and a SHAPE
no wrapper can express, which is emitted as a stub carrying the same reason.
Neither is ever filled in on this side — the fix for a row here is upstream in
MEOS or MEOS-API, where every binding inherits it.

A kind with no rows is a site the generators watch and that nothing reached in
this run.  It prints so that an empty class reads as a measurement rather than
as a class nobody looked at.

Generated from `meos-idl.json` at MobilityDB `{commit}` by `tools/codegen.py`
and `tools/objectgen.py`.  Do not edit.
"""

_BEGIN = "<!-- gap-ledger:begin {name} -->"
_END = "<!-- gap-ledger:end {name} -->"
_PLACEHOLDER = "_Not recorded in this run — regenerate with `tools/refresh-from-master.sh`._"


def _cell(text: str) -> str:
    """One table cell: a pipe would end the column and a newline the row."""
    return str(text).replace("|", "\\|").replace("\n", " ").strip()


class Ledger:
    """One generator's account of what it could not derive.

    ``kind`` registers a class of gap with the contract it is missing and the
    column headings its rows carry; ``record`` adds one row to it.  A kind is
    registered whether or not it fires, which is what lets an empty class print.
    """

    def __init__(self, section: str, title: str) -> None:
        if section not in SECTIONS:
            raise SystemExit(f"gapledger: unknown section {section!r}")
        self.section = section
        self.title = title
        self._kinds: dict[str, tuple[str, tuple[str, ...]]] = {}
        self._rows: dict[str, list[tuple[str, ...]]] = {}

    def kind(self, name: str, missing: str, columns: tuple[str, ...]) -> None:
        self._kinds[name] = (missing, columns)
        self._rows.setdefault(name, [])

    def record(self, kind: str, *row: str) -> None:
        if kind not in self._kinds:
            raise SystemExit(f"gapledger: {kind!r} recorded before it was declared")
        _missing, columns = self._kinds[kind]
        if len(row) != len(columns):
            raise SystemExit(
                f"gapledger: {kind!r} takes {len(columns)} columns, given {len(row)}")
        self._rows[kind].append(tuple(str(c) for c in row))

    @property
    def total(self) -> int:
        return sum(len(rows) for rows in self._rows.values())

    def render(self) -> str:
        out = [f"## {self.title}", ""]
        for name in self._kinds:
            missing, columns = self._kinds[name]
            rows = sorted(self._rows[name])
            out += [f"### {name} — {len(rows)}", "", missing, ""]
            if not rows:
                out += ["None in this run.", ""]
                continue
            out += ["| " + " | ".join(columns) + " |",
                    "| " + " | ".join("---" for _ in columns) + " |"]
            out += ["| " + " | ".join(_cell(c) for c in row) + " |" for row in rows]
            out.append("")
        return "\n".join(out)

    def write(self, repo_root: Path, commit: str) -> Path:
        path = Path(repo_root) / LEDGER_FILE
        existing = path.read_text() if path.exists() else ""
        bodies = {name: _section_body(existing, name) for name in SECTIONS}
        bodies[self.section] = self.render()
        text = _PREAMBLE.format(commit=commit)
        for name in SECTIONS:
            body = bodies[name] or _PLACEHOLDER
            text += ("\n" + _BEGIN.format(name=name) + "\n\n"
                     + body.rstrip() + "\n\n" + _END.format(name=name) + "\n")
        path.write_text(text)
        return path


def stub_comment(subject: str, reason: str, indent: str = "        ") -> list[str]:
    """The comment the generated surface carries where a wrapper cannot go.

    GoMEOS's ``_todo_stub`` is the shape: the reason travels with the code as
    well as into this file, so a reader of the surface asking why a function has
    no wrapper finds the answer where the wrapper would have been."""
    lines = _wrap(f"GAP {subject}: {reason}", 88 - len(indent))
    return [f"{indent}// {lines[0]}"] + [f"{indent}//     {line}" for line in lines[1:]]


def _section_body(text: str, name: str) -> str:
    """What the file already holds for a section, or the empty string."""
    match = re.search(
        re.escape(_BEGIN.format(name=name)) + r"\n(.*?)\n?" + re.escape(_END.format(name=name)),
        text, re.S)
    body = match.group(1).strip() if match else ""
    return "" if body == _PLACEHOLDER else body


def _wrap(text: str, width: int) -> list[str]:
    lines: list[str] = []
    line = ""
    for word in text.split():
        if line and len(line) + 1 + len(word) > width:
            lines.append(line)
            line = word
        else:
            line = f"{line} {word}".strip()
    if line:
        lines.append(line)
    return lines
