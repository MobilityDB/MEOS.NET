# Gap ledger

Every contract the MEOS.NET generators need and the MEOS API catalog does not
state.  Two kinds of row: a CONTRACT the surface is emitted without, and a SHAPE
no wrapper can express, which is emitted as a stub carrying the same reason.
Neither is ever filled in on this side — the fix for a row here is upstream in
MEOS or MEOS-API, where every binding inherits it.

A kind with no rows is a site the generators watch and that nothing reached in
this run.  It prints so that an empty class reads as a measurement rather than
as a class nobody looked at.

Generated from `meos-idl.json` at MobilityDB `79a66f4576902b933481883443334c67edccf607` by `tools/codegen.py`
and `tools/objectgen.py`.  Do not edit.

<!-- gap-ledger:begin flat surface -->

## The flat surface — `tools/codegen.py`

### parameter nullability — 3936

`shape.nullable` names the parameters a function accepts NULL for, and the catalog carries no field saying a parameter is required. A pointer parameter named in neither reaches the surface with its contract unstated: the wrapper takes it, and nothing says whether zero is an argument or a fault.

| function | parameters whose nullability is unstated |
| --- | --- |
| above_stbox_stbox | box1, box2 |
| above_stbox_tspatial | box, temp |
| above_tpcbox_tpcbox | box1, box2 |
| above_tspatial_stbox | temp, box |
| above_tspatial_tspatial | temp1, temp2 |
| acontains_cbuffer_tcbuffer | cb, temp |
| acontains_geo_tcbuffer | gs, temp |
| acontains_geo_tgeo | gs, temp |
| acontains_geo_trgeometry | gs, temp |
| acontains_tcbuffer_cbuffer | temp, cb |
| acontains_tcbuffer_geo | temp, gs |
| acontains_tcbuffer_tcbuffer | temp1, temp2 |
| acontains_tgeo_geo | temp, gs |
| acontains_tgeo_tgeo | temp1, temp2 |
| acovers_cbuffer_tcbuffer | cb, temp |
| acovers_geo_tcbuffer | gs, temp |
| acovers_geo_tgeo | gs, temp |
| acovers_geo_trgeometry | gs, temp |
| acovers_tcbuffer_cbuffer | temp, cb |
| acovers_tcbuffer_geo | temp, gs |
| acovers_tcbuffer_tcbuffer | temp1, temp2 |
| acovers_tgeo_geo | temp, gs |
| acovers_tgeo_tgeo | temp1, temp2 |
| acovers_trgeometry_geo | temp, gs |
| add_bigint_tbigint | tnumber |
| add_date_interval | interv |
| add_float_tfloat | tnumber |
| add_int_tint | tnumber |
| add_interval_interval | interv1, interv2 |
| add_tbigint_bigint | tnumber |
| add_tfloat_float | tnumber |
| add_timestamp_interval | interv |
| add_timestamptz_interval | interv |
| add_timestamptz_interval_at_zone | interv, zone |
| add_tint_int | tnumber |
| add_tnumber_tnumber | tnumber1, tnumber2 |
| adisjoint_geo_tgeo | gs, temp |
| adisjoint_tcbuffer_cbuffer | temp, cb |
| adisjoint_tcbuffer_geo | temp, gs |
| adisjoint_tcbuffer_tcbuffer | temp1, temp2 |
| adisjoint_tgeo_geo | temp, gs |
| adisjoint_tgeo_tgeo | temp1, temp2 |
| adisjoint_tgeoarr_tgeoarr | arr1, arr2, count |
| adisjoint_trgeometry_geo | temp, gs |
| adisjoint_trgeometry_trgeometry | temp1, temp2 |
| adjacent_bigint_span | s |
| adjacent_date_span | s |
| adjacent_float_span | s |
| adjacent_int_span | s |
| adjacent_numspan_tnumber | s, temp |
| adjacent_span_bigint | s |
| adjacent_span_date | s |
| adjacent_span_float | s |
| adjacent_span_int | s |
| adjacent_span_span | s1, s2 |
| adjacent_span_spanset | s, ss |
| adjacent_span_timestamptz | s |
| adjacent_span_value | s |
| adjacent_spanset_bigint | ss |
| adjacent_spanset_date | ss |
| adjacent_spanset_float | ss |
| adjacent_spanset_int | ss |
| adjacent_spanset_span | ss, s |
| adjacent_spanset_spanset | ss1, ss2 |
| adjacent_spanset_timestamptz | ss |
| adjacent_spanset_value | ss |
| adjacent_stbox_stbox | box1, box2 |
| adjacent_stbox_tspatial | box, temp |
| adjacent_tbox_tbox | box1, box2 |
| adjacent_tbox_tnumber | box, temp |
| adjacent_temporal_temporal | temp1, temp2 |
| adjacent_temporal_tstzspan | temp, s |
| adjacent_timestamptz_span | s |
| adjacent_tnumber_numspan | temp, s |
| adjacent_tnumber_tbox | temp, box |
| adjacent_tnumber_tnumber | temp1, temp2 |
| adjacent_tpcbox_tpcbox | box1, box2 |
| adjacent_tpcbox_tpointcloud | box, temp |
| adjacent_tpointcloud_tpcbox | temp, box |
| adjacent_tpointcloud_tpointcloud | temp1, temp2 |
| adjacent_tspatial_stbox | temp, box |
| adjacent_tspatial_tspatial | temp1, temp2 |
| adjacent_tstzspan_temporal | s, temp |
| adjacent_value_spanset | ss |
| adwithin_geo_tgeo | gs, temp |
| adwithin_tcbuffer_cbuffer | temp, cb |
| adwithin_tcbuffer_geo | temp, gs |
| adwithin_tcbuffer_tcbuffer | temp1, temp2 |
| adwithin_tgeo_geo | temp, gs |
| adwithin_tgeo_tgeo | temp1, temp2 |
| adwithin_tgeoarr_tgeoarr | arr1, arr2, count |
| adwithin_trgeometry_geo | temp, gs |
| adwithin_trgeometry_trgeometry | temp1, temp2 |
| after_date_set | s |
| after_date_span | s |
| after_date_spanset | ss |
| after_set_date | s |
| after_set_timestamptz | s |
| after_span_date | s |
| after_span_timestamptz | s |
| after_spanset_date | ss |
| after_spanset_timestamptz | ss |
| after_stbox_stbox | box1, box2 |
| after_stbox_tspatial | box, temp |
| after_tbox_tbox | box1, box2 |
| after_tbox_tnumber | box, temp |
| after_temporal_temporal | temp1, temp2 |
| after_temporal_tstzspan | temp, s |
| after_timestamptz_set | s |
| after_timestamptz_span | s |
| after_timestamptz_spanset | ss |
| after_tnumber_tbox | temp, box |
| after_tnumber_tnumber | temp1, temp2 |
| after_tpcbox_tpcbox | box1, box2 |
| after_tspatial_stbox | temp, box |
| after_tspatial_tspatial | temp1, temp2 |
| after_tstzspan_temporal | s, temp |
| aintersects_geo_tgeo | gs, temp |
| aintersects_tcbuffer_cbuffer | temp, cb |
| aintersects_tcbuffer_geo | temp, gs |
| aintersects_tcbuffer_tcbuffer | temp1, temp2 |
| aintersects_tgeo_geo | temp, gs |
| aintersects_tgeo_tgeo | temp1, temp2 |
| aintersects_tgeoarr_tgeoarr | arr1, arr2, count |
| aintersects_trgeometry_geo | temp, gs |
| aintersects_trgeometry_trgeometry | temp1, temp2 |
| always_eq_base_temporal | temp |
| always_eq_bigint_tbigint | temp |
| always_eq_bool_tbool | temp |
| always_eq_cbuffer_tcbuffer | cb, temp |
| always_eq_float_tfloat | temp |
| always_eq_geo_tgeo | gs, temp |
| always_eq_geo_trgeometry | gs, temp |
| always_eq_h3index_th3index | temp |
| always_eq_int_tint | temp |
| always_eq_jsonb_tjsonb | jb, temp |
| always_eq_npoint_tnpoint | np, temp |
| always_eq_pcpatch_tpcpatch | pa, temp |
| always_eq_pcpoint_tpcpoint | pt, temp |
| always_eq_pose_tpose | pose, temp |
| always_eq_posechain_tposechain | posechain, temp |
| always_eq_quadbin_tquadbin | temp |
| always_eq_s2cell_ts2cell | temp |
| always_eq_tbigint_bigint | temp |
| always_eq_tbool_bool | temp |
| always_eq_tcbuffer_cbuffer | temp, cb |
| always_eq_tcbuffer_tcbuffer | temp1, temp2 |
| always_eq_temporal_base | temp |
| always_eq_temporal_temporal | temp1, temp2 |
| always_eq_text_ttext | txt, temp |
| always_eq_tfloat_float | temp |
| always_eq_tgeo_geo | temp, gs |
| always_eq_tgeo_tgeo | temp1, temp2 |
| always_eq_th3index_h3index | temp |
| always_eq_th3index_th3index | temp1, temp2 |
| always_eq_tint_int | temp |
| always_eq_tjsonb_jsonb | temp, jb |
| always_eq_tjsonb_tjsonb | temp1, temp2 |
| always_eq_tnpoint_npoint | temp, np |
| always_eq_tnpoint_tnpoint | temp1, temp2 |
| always_eq_tpcpatch_pcpatch | temp, pa |
| always_eq_tpcpatch_tpcpatch | temp1, temp2 |
| always_eq_tpcpoint_pcpoint | temp, pt |
| always_eq_tpcpoint_tpcpoint | temp1, temp2 |
| always_eq_tpose_pose | temp, pose |
| always_eq_tpose_tpose | temp1, temp2 |
| always_eq_tposechain_posechain | temp, posechain |
| always_eq_tposechain_tposechain | temp1, temp2 |
| always_eq_tquadbin_quadbin | temp |
| always_eq_tquadbin_tquadbin | temp1, temp2 |
| always_eq_trgeometry_geo | temp, gs |
| always_eq_trgeometry_trgeometry | temp1, temp2 |
| always_eq_ts2cell_s2cell | temp |
| always_eq_ts2cell_ts2cell | temp1, temp2 |
| always_eq_ttext_text | temp, txt |
| always_ge_base_temporal | temp |
| always_ge_bigint_tbigint | temp |
| always_ge_float_tfloat | temp |
| always_ge_int_tint | temp |
| always_ge_tbigint_bigint | temp |
| always_ge_temporal_base | temp |
| always_ge_temporal_temporal | temp1, temp2 |
| always_ge_text_ttext | txt, temp |
| always_ge_tfloat_float | temp |
| always_ge_tint_int | temp |
| always_ge_ttext_text | temp, txt |
| always_gt_base_temporal | temp |
| always_gt_bigint_tbigint | temp |
| always_gt_float_tfloat | temp |
| always_gt_int_tint | temp |
| always_gt_tbigint_bigint | temp |
| always_gt_temporal_base | temp |
| always_gt_temporal_temporal | temp1, temp2 |
| always_gt_text_ttext | txt, temp |
| always_gt_tfloat_float | temp |
| always_gt_tint_int | temp |
| always_gt_ttext_text | temp, txt |
| always_le_base_temporal | temp |
| always_le_bigint_tbigint | temp |
| always_le_float_tfloat | temp |
| always_le_int_tint | temp |
| always_le_tbigint_bigint | temp |
| always_le_temporal_base | temp |
| always_le_temporal_temporal | temp1, temp2 |
| always_le_text_ttext | txt, temp |
| always_le_tfloat_float | temp |
| always_le_tint_int | temp |
| always_le_ttext_text | temp, txt |
| always_lt_base_temporal | temp |
| always_lt_bigint_tbigint | temp |
| always_lt_float_tfloat | temp |
| always_lt_int_tint | temp |
| always_lt_tbigint_bigint | temp |
| always_lt_temporal_base | temp |
| always_lt_temporal_temporal | temp1, temp2 |
| always_lt_text_ttext | txt, temp |
| always_lt_tfloat_float | temp |
| always_lt_tint_int | temp |
| always_lt_ttext_text | temp, txt |
| always_ne_base_temporal | temp |
| always_ne_bigint_tbigint | temp |
| always_ne_bool_tbool | temp |
| always_ne_cbuffer_tcbuffer | cb, temp |
| always_ne_float_tfloat | temp |
| always_ne_geo_tgeo | gs, temp |
| always_ne_geo_trgeometry | gs, temp |
| always_ne_h3index_th3index | temp |
| always_ne_int_tint | temp |
| always_ne_jsonb_tjsonb | jb, temp |
| always_ne_npoint_tnpoint | np, temp |
| always_ne_pcpatch_tpcpatch | pa, temp |
| always_ne_pcpoint_tpcpoint | pt, temp |
| always_ne_pose_tpose | pose, temp |
| always_ne_posechain_tposechain | posechain, temp |
| always_ne_quadbin_tquadbin | temp |
| always_ne_s2cell_ts2cell | temp |
| always_ne_tbigint_bigint | temp |
| always_ne_tbool_bool | temp |
| always_ne_tcbuffer_cbuffer | temp, cb |
| always_ne_tcbuffer_tcbuffer | temp1, temp2 |
| always_ne_temporal_base | temp |
| always_ne_temporal_temporal | temp1, temp2 |
| always_ne_text_ttext | txt, temp |
| always_ne_tfloat_float | temp |
| always_ne_tgeo_geo | temp, gs |
| always_ne_tgeo_tgeo | temp1, temp2 |
| always_ne_th3index_h3index | temp |
| always_ne_th3index_th3index | temp1, temp2 |
| always_ne_tint_int | temp |
| always_ne_tjsonb_jsonb | temp, jb |
| always_ne_tjsonb_tjsonb | temp1, temp2 |
| always_ne_tnpoint_npoint | temp, np |
| always_ne_tnpoint_tnpoint | temp1, temp2 |
| always_ne_tpcpatch_pcpatch | temp, pa |
| always_ne_tpcpatch_tpcpatch | temp1, temp2 |
| always_ne_tpcpoint_pcpoint | temp, pt |
| always_ne_tpcpoint_tpcpoint | temp1, temp2 |
| always_ne_tpose_pose | temp, pose |
| always_ne_tpose_tpose | temp1, temp2 |
| always_ne_tposechain_posechain | temp, posechain |
| always_ne_tposechain_tposechain | temp1, temp2 |
| always_ne_tquadbin_quadbin | temp |
| always_ne_tquadbin_tquadbin | temp1, temp2 |
| always_ne_trgeometry_geo | temp, gs |
| always_ne_trgeometry_trgeometry | temp1, temp2 |
| always_ne_ts2cell_s2cell | temp |
| always_ne_ts2cell_ts2cell | temp1, temp2 |
| always_ne_ttext_text | temp, txt |
| araster_value | traj, rast, vspan |
| araster_value_gdal | traj, path, vspan |
| atouches_geo_tgeo | gs, temp |
| atouches_geo_tpoint | gs, temp |
| atouches_tcbuffer_cbuffer | temp, cb |
| atouches_tcbuffer_geo | temp, gs |
| atouches_tcbuffer_tcbuffer | temp1, temp2 |
| atouches_tgeo_geo | temp, gs |
| atouches_tgeo_tgeo | temp1, temp2 |
| atouches_tgeoarr_tgeoarr | arr1, arr2, count |
| atouches_tpoint_geo | temp, gs |
| atouches_trgeometry_geo | temp, gs |
| back_stbox_stbox | box1, box2 |
| back_stbox_tspatial | box, temp |
| back_tpcbox_tpcbox | box1, box2 |
| back_tspatial_stbox | temp, box |
| back_tspatial_tspatial | temp1, temp2 |
| basetype_in | str, result |
| bbox_temporal_split_boxes | temp, count |
| bbox_union_span_span | s1, s2, result |
| bearing_point_point | gs1, gs2, result |
| bearing_tpoint_point | temp, gs |
| bearing_tpoint_tpoint | temp1, temp2 |
| before_date_set | s |
| before_date_span | s |
| before_date_spanset | ss |
| before_set_date | s |
| before_set_timestamptz | s |
| before_span_date | s |
| before_span_timestamptz | s |
| before_spanset_date | ss |
| before_spanset_timestamptz | ss |
| before_stbox_stbox | box1, box2 |
| before_stbox_tspatial | box, temp |
| before_tbox_tbox | box1, box2 |
| before_tbox_tnumber | box, temp |
| before_temporal_temporal | temp1, temp2 |
| before_temporal_tstzspan | temp, s |
| before_timestamptz_set | s |
| before_timestamptz_span | s |
| before_timestamptz_spanset | ss |
| before_tnumber_tbox | temp, box |
| before_tnumber_tnumber | temp1, temp2 |
| before_tpcbox_tpcbox | box1, box2 |
| before_tspatial_stbox | temp, box |
| before_tspatial_tspatial | temp1, temp2 |
| before_tstzspan_temporal | s, temp |
| below_stbox_stbox | box1, box2 |
| below_stbox_tspatial | box, temp |
| below_tpcbox_tpcbox | box1, box2 |
| below_tspatial_stbox | temp, box |
| below_tspatial_tspatial | temp1, temp2 |
| bigint_tstzspan_to_tbox | s |
| bigint_union_transfn | state |
| bigintset_end_value | s |
| bigintset_in | str |
| bigintset_make | values |
| bigintset_out | set |
| bigintset_shift_scale | s |
| bigintset_start_value | s |
| bigintset_value_n | s, result |
| bigintset_values | s, count |
| bigintspan_bins | s, count |
| bigintspan_expand | s |
| bigintspan_in | str |
| bigintspan_lower | s |
| bigintspan_out | s |
| bigintspan_set_floatspan | s1, s2 |
| bigintspan_set_intspan | s1, s2 |
| bigintspan_shift_scale | s |
| bigintspan_to_floatspan | s |
| bigintspan_to_intspan | s |
| bigintspan_upper | s |
| bigintspan_width | s |
| bigintspanset_bins | ss, count |
| bigintspanset_in | str |
| bigintspanset_lower | ss |
| bigintspanset_out | ss |
| bigintspanset_shift_scale | ss |
| bigintspanset_upper | ss |
| bigintspanset_width | ss |
| bool_in | str |
| box3d_in | str |
| box3d_out | box |
| box3d_to_stbox | box |
| bytea_copy | ba |
| cbuffer_as_ewkt | cb |
| cbuffer_as_hexwkb | cb, size_out |
| cbuffer_as_text | cb |
| cbuffer_as_wkb | cb, size_out |
| cbuffer_cmp | cb1, cb2 |
| cbuffer_copy | cb |
| cbuffer_eq | cb1, cb2 |
| cbuffer_from_hexwkb | hexwkb |
| cbuffer_from_wkb | wkb |
| cbuffer_ge | cb1, cb2 |
| cbuffer_gt | cb1, cb2 |
| cbuffer_hash | cb |
| cbuffer_hash_extended | cb |
| cbuffer_in | str |
| cbuffer_le | cb1, cb2 |
| cbuffer_lt | cb1, cb2 |
| cbuffer_make | point |
| cbuffer_ne | cb1, cb2 |
| cbuffer_nsame | cb1, cb2 |
| cbuffer_out | cb |
| cbuffer_point | cb |
| cbuffer_radius | cb |
| cbuffer_round | cb |
| cbuffer_same | cb1, cb2 |
| cbuffer_set_srid | cb |
| cbuffer_srid | cb |
| cbuffer_timestamptz_to_stbox | cb |
| cbuffer_to_geom | cb |
| cbuffer_to_set | cb |
| cbuffer_to_stbox | cb |
| cbuffer_transform | cb |
| cbuffer_transform_pipeline | cb, pipelinestr |
| cbuffer_tstzspan_to_stbox | cb, s |
| cbuffer_union_transfn | state, cb |
| cbufferarr_round | cbarr |
| cbufferarr_to_geom | cbarr |
| cbufferset_end_value | s |
| cbufferset_in | str |
| cbufferset_make | values |
| cbufferset_out | s |
| cbufferset_start_value | s |
| cbufferset_value_n | s, result |
| cbufferset_values | s, count |
| concat_jsonbset_jsonb | s, jb |
| concat_tjsonb_jsonb | temp, jb |
| concat_tjsonb_tjsonb | temp1, temp2 |
| contained_bigint_set | s |
| contained_bigint_span | s |
| contained_bigint_spanset | ss |
| contained_cbuffer_set | cb, s |
| contained_date_set | s |
| contained_date_span | s |
| contained_date_spanset | ss |
| contained_float_set | s |
| contained_float_span | s |
| contained_float_spanset | ss |
| contained_geo_set | gs, s |
| contained_int_set | s |
| contained_int_span | s |
| contained_int_spanset | ss |
| contained_jsonb_set | jb, s |
| contained_npoint_set | np, s |
| contained_numspan_tnumber | s, temp |
| contained_pcpatch_set | pa, s |
| contained_pcpoint_set | pt, s |
| contained_pose_set | pose, s |
| contained_posechain_set | pc, s |
| contained_set_set | s1, s2 |
| contained_span_span | s1, s2 |
| contained_span_spanset | s, ss |
| contained_spanset_span | ss, s |
| contained_spanset_spanset | ss1, ss2 |
| contained_stbox_stbox | box1, box2 |
| contained_stbox_tspatial | box, temp |
| contained_tbox_tbox | box1, box2 |
| contained_tbox_tnumber | box, temp |
| contained_temporal_temporal | temp1, temp2 |
| contained_temporal_tstzspan | temp, s |
| contained_text_set | txt, s |
| contained_timestamptz_set | s |
| contained_timestamptz_span | s |
| contained_timestamptz_spanset | ss |
| contained_tnumber_numspan | temp, s |
| contained_tnumber_tbox | temp, box |
| contained_tnumber_tnumber | temp1, temp2 |
| contained_tpcbox_tpcbox | box1, box2 |
| contained_tpcbox_tpointcloud | box, temp |
| contained_tpointcloud_tpcbox | temp, box |
| contained_tpointcloud_tpointcloud | temp1, temp2 |
| contained_tspatial_stbox | temp, box |
| contained_tspatial_tspatial | temp1, temp2 |
| contained_tstzspan_temporal | s, temp |
| contained_value_set | s |
| contained_value_span | s |
| contained_value_spanset | ss |
| contains_cbuffer_cbuffer | cb1, cb2 |
| contains_numspan_tnumber | s, temp |
| contains_set_bigint | s |
| contains_set_cbuffer | s, cb |
| contains_set_date | s |
| contains_set_float | s |
| contains_set_geo | s, gs |
| contains_set_int | s |
| contains_set_jsonb | s, jb |
| contains_set_npoint | s, np |
| contains_set_pcpatch | s, pa |
| contains_set_pcpoint | s, pt |
| contains_set_pose | s, pose |
| contains_set_posechain | s, pc |
| contains_set_set | s1, s2 |
| contains_set_text | s, t |
| contains_set_timestamptz | s |
| contains_set_value | s |
| contains_span_bigint | s |
| contains_span_date | s |
| contains_span_float | s |
| contains_span_int | s |
| contains_span_span | s1, s2 |
| contains_span_spanset | s, ss |
| contains_span_timestamptz | s |
| contains_span_value | s |
| contains_spanset_bigint | ss |
| contains_spanset_date | ss |
| contains_spanset_float | ss |
| contains_spanset_int | ss |
| contains_spanset_span | ss, s |
| contains_spanset_spanset | ss1, ss2 |
| contains_spanset_timestamptz | ss |
| contains_spanset_value | ss |
| contains_stbox_stbox | box1, box2 |
| contains_stbox_tspatial | box, temp |
| contains_tbox_tbox | box1, box2 |
| contains_tbox_tnumber | box, temp |
| contains_temporal_temporal | temp1, temp2 |
| contains_temporal_tstzspan | temp, s |
| contains_tjsonb_jsonb | temp, jb |
| contains_tjsonb_tjsonb | temp1, temp2 |
| contains_tnumber_numspan | temp, s |
| contains_tnumber_tbox | temp, box |
| contains_tnumber_tnumber | temp1, temp2 |
| contains_tpcbox_tpcbox | box1, box2 |
| contains_tpcbox_tpointcloud | box, temp |
| contains_tpointcloud_tpcbox | temp, box |
| contains_tpointcloud_tpointcloud | temp1, temp2 |
| contains_tspatial_stbox | temp, box |
| contains_tspatial_tspatial | temp1, temp2 |
| contains_tstzspan_temporal | s, temp |
| covers_cbuffer_cbuffer | cb1, cb2 |
| cstring_to_text | str |
| date_extract | units |
| date_get_bin | duration |
| date_in | str |
| date_timetz_to_timestamptz | timetz |
| date_union_transfn | state |
| dateset_end_value | s |
| dateset_in | str |
| dateset_make | values |
| dateset_out | s |
| dateset_shift_scale | s |
| dateset_start_value | s |
| dateset_to_tstzset | s |
| dateset_value_n | s, result |
| dateset_values | s, count |
| datespan_bins | s, duration, count |
| datespan_duration | s |
| datespan_in | str |
| datespan_lower | s |
| datespan_out | s |
| datespan_set_tstzspan | s1, s2 |
| datespan_shift_scale | s |
| datespan_to_tstzspan | s |
| datespan_upper | s |
| datespanset_bins | ss, duration, count |
| datespanset_date_n | ss, result |
| datespanset_dates | ss |
| datespanset_duration | ss |
| datespanset_end_date | ss |
| datespanset_in | str |
| datespanset_lower | ss |
| datespanset_num_dates | ss |
| datespanset_out | ss |
| datespanset_shift_scale | ss |
| datespanset_start_date | ss |
| datespanset_to_tstzspanset | ss |
| datespanset_upper | ss |
| disjoint_cbuffer_cbuffer | cb1, cb2 |
| distance_bigintset_bigintset | s1, s2 |
| distance_bigintspan_bigintspan | s1, s2 |
| distance_bigintspanset_bigintspan | ss, s |
| distance_bigintspanset_bigintspanset | ss1, ss2 |
| distance_cbuffer_cbuffer | cb1, cb2 |
| distance_cbuffer_geo | cb, gs |
| distance_cbuffer_stbox | cb, box |
| distance_dateset_dateset | s1, s2 |
| distance_datespan_datespan | s1, s2 |
| distance_datespanset_datespan | ss, s |
| distance_datespanset_datespanset | ss1, ss2 |
| distance_floatset_floatset | s1, s2 |
| distance_floatspan_floatspan | s1, s2 |
| distance_floatspanset_floatspan | ss, s |
| distance_floatspanset_floatspanset | ss1, ss2 |
| distance_intset_intset | s1, s2 |
| distance_intspan_intspan | s1, s2 |
| distance_intspanset_intspan | ss, s |
| distance_intspanset_intspanset | ss1, ss2 |
| distance_pose_geo | pose, gs |
| distance_pose_pose | pose1, pose2 |
| distance_pose_stbox | pose, box |
| distance_set_bigint | s |
| distance_set_date | s |
| distance_set_float | s |
| distance_set_int | s |
| distance_set_set | s1, s2 |
| distance_set_timestamptz | s |
| distance_set_value | s |
| distance_span_bigint | s |
| distance_span_date | s |
| distance_span_float | s |
| distance_span_int | s |
| distance_span_span | s1, s2 |
| distance_span_timestamptz | s |
| distance_span_value | s |
| distance_spanset_bigint | ss |
| distance_spanset_date | ss |
| distance_spanset_float | ss |
| distance_spanset_int | ss |
| distance_spanset_span | ss, s |
| distance_spanset_spanset | ss1, ss2 |
| distance_spanset_timestamptz | ss |
| distance_spanset_value | ss |
| distance_spatialset_spatialset | s1, s2 |
| distance_spatialset_value | s |
| distance_tstzset_tstzset | s1, s2 |
| distance_tstzspan_tstzspan | s1, s2 |
| distance_tstzspanset_tstzspan | ss, s |
| distance_tstzspanset_tstzspanset | ss1, ss2 |
| div_bigint_tbigint | tnumber |
| div_float_tfloat | tnumber |
| div_int_tint | tnumber |
| div_interval_float8 | interv |
| div_tbigint_bigint | tnumber |
| div_tfloat_float | tnumber |
| div_tint_int | tnumber |
| div_tnumber_tnumber | tnumber1, tnumber2 |
| dwithin_cbuffer_cbuffer | cb1, cb2 |
| econtains_cbuffer_tcbuffer | cb, temp |
| econtains_geo_tgeo | gs, temp |
| econtains_geo_trgeometry | gs, temp |
| econtains_tcbuffer_cbuffer | temp, cb |
| econtains_tcbuffer_geo | temp, gs |
| econtains_tcbuffer_tcbuffer | temp1, temp2 |
| econtains_tgeo_geo | temp, gs |
| econtains_tgeo_tgeo | temp1, temp2 |
| ecovers_cbuffer_tcbuffer | cb, temp |
| ecovers_geo_tcbuffer | gs, temp |
| ecovers_geo_tgeo | gs, temp |
| ecovers_geo_trgeometry | gs, temp |
| ecovers_tcbuffer_cbuffer | temp, cb |
| ecovers_tcbuffer_geo | temp, gs |
| ecovers_tcbuffer_tcbuffer | temp1, temp2 |
| ecovers_tgeo_geo | temp, gs |
| ecovers_tgeo_tgeo | temp1, temp2 |
| ecovers_trgeometry_geo | temp, gs |
| edisjoint_geo_tgeo | gs, temp |
| edisjoint_tcbuffer_cbuffer | temp, cb |
| edisjoint_tcbuffer_geo | temp, gs |
| edisjoint_tgeo_geo | temp, gs |
| edisjoint_tgeo_tgeo | temp1, temp2 |
| edisjoint_tgeoarr_tgeoarr | arr1, arr2, count |
| edisjoint_trgeometry_geo | temp, gs |
| edisjoint_trgeometry_trgeometry | temp1, temp2 |
| edwithin_geo_tgeo | gs, temp |
| edwithin_tcbuffer_cbuffer | temp, cb |
| edwithin_tcbuffer_geo | temp, gs |
| edwithin_tcbuffer_tcbuffer | temp1, temp2 |
| edwithin_tgeo_geo | temp, gs |
| edwithin_tgeo_tgeo | temp1, temp2 |
| edwithin_tgeoarr_tgeoarr | arr1, arr2, count |
| edwithin_trgeometry_geo | temp, gs |
| edwithin_trgeometry_trgeometry | temp1, temp2 |
| eintersects_geo_tgeo | gs, temp |
| eintersects_tcbuffer_cbuffer | temp, cb |
| eintersects_tcbuffer_geo | temp, gs |
| eintersects_tcbuffer_tcbuffer | temp1, temp2 |
| eintersects_tgeo_geo | temp, gs |
| eintersects_tgeo_tgeo | temp1, temp2 |
| eintersects_tgeoarr_tgeoarr | arr1, arr2, count |
| eintersects_tpcpoint_geo | temp, gs |
| eintersects_trgeometry_geo | temp, gs |
| eintersects_trgeometry_trgeometry | temp1, temp2 |
| ensure_bbox_temporal_compatible | temp |
| eraster_value | traj, rast, vspan |
| eraster_value_gdal | traj, path, vspan |
| etouches_geo_tgeo | gs, temp |
| etouches_geo_tpoint | gs, temp |
| etouches_tcbuffer_cbuffer | temp, cb |
| etouches_tcbuffer_geo | temp, gs |
| etouches_tcbuffer_tcbuffer | temp1, temp2 |
| etouches_tgeo_geo | temp, gs |
| etouches_tgeo_tgeo | temp1, temp2 |
| etouches_tgeoarr_tgeoarr | arr1, arr2, count |
| etouches_tpoint_geo | temp, gs |
| etouches_trgeometry_geo | temp, gs |
| ever_eq_base_temporal | temp |
| ever_eq_bigint_tbigint | temp |
| ever_eq_bool_tbool | temp |
| ever_eq_cbuffer_tcbuffer | cb, temp |
| ever_eq_float_tfloat | temp |
| ever_eq_geo_tgeo | gs, temp |
| ever_eq_geo_trgeometry | gs, temp |
| ever_eq_h3index_th3index | temp |
| ever_eq_h3indexset_th3index | cells, th3idx |
| ever_eq_int_tint | temp |
| ever_eq_jsonb_tjsonb | jb, temp |
| ever_eq_npoint_tnpoint | np, temp |
| ever_eq_pcpatch_tpcpatch | pa, temp |
| ever_eq_pcpoint_tpcpoint | pt, temp |
| ever_eq_pose_tpose | pose, temp |
| ever_eq_posechain_tposechain | posechain, temp |
| ever_eq_quadbin_tquadbin | temp |
| ever_eq_s2cell_ts2cell | temp |
| ever_eq_tbigint_bigint | temp |
| ever_eq_tbool_bool | temp |
| ever_eq_tcbuffer_cbuffer | temp, cb |
| ever_eq_tcbuffer_tcbuffer | temp1, temp2 |
| ever_eq_temporal_base | temp |
| ever_eq_temporal_temporal | temp1, temp2 |
| ever_eq_text_ttext | txt, temp |
| ever_eq_tfloat_float | temp |
| ever_eq_tgeo_geo | temp, gs |
| ever_eq_tgeo_tgeo | temp1, temp2 |
| ever_eq_th3index_h3index | temp |
| ever_eq_th3index_th3index | temp1, temp2 |
| ever_eq_tint_int | temp |
| ever_eq_tjsonb_jsonb | temp, jb |
| ever_eq_tjsonb_tjsonb | temp1, temp2 |
| ever_eq_tnpoint_npoint | temp, np |
| ever_eq_tnpoint_tnpoint | temp1, temp2 |
| ever_eq_tpcpatch_pcpatch | temp, pa |
| ever_eq_tpcpatch_tpcpatch | temp1, temp2 |
| ever_eq_tpcpoint_pcpoint | temp, pt |
| ever_eq_tpcpoint_tpcpoint | temp1, temp2 |
| ever_eq_tpose_pose | temp, pose |
| ever_eq_tpose_tpose | temp1, temp2 |
| ever_eq_tposechain_posechain | temp, posechain |
| ever_eq_tposechain_tposechain | temp1, temp2 |
| ever_eq_tquadbin_quadbin | temp |
| ever_eq_tquadbin_tquadbin | temp1, temp2 |
| ever_eq_trgeometry_geo | temp, gs |
| ever_eq_trgeometry_trgeometry | temp1, temp2 |
| ever_eq_ts2cell_s2cell | temp |
| ever_eq_ts2cell_ts2cell | temp1, temp2 |
| ever_eq_ttext_text | temp, txt |
| ever_ge_base_temporal | temp |
| ever_ge_bigint_tbigint | temp |
| ever_ge_float_tfloat | temp |
| ever_ge_int_tint | temp |
| ever_ge_tbigint_bigint | temp |
| ever_ge_temporal_base | temp |
| ever_ge_temporal_temporal | temp1, temp2 |
| ever_ge_text_ttext | txt, temp |
| ever_ge_tfloat_float | temp |
| ever_ge_tint_int | temp |
| ever_ge_ttext_text | temp, txt |
| ever_gt_base_temporal | temp |
| ever_gt_bigint_tbigint | temp |
| ever_gt_float_tfloat | temp |
| ever_gt_int_tint | temp |
| ever_gt_tbigint_bigint | temp |
| ever_gt_temporal_base | temp |
| ever_gt_temporal_temporal | temp1, temp2 |
| ever_gt_text_ttext | txt, temp |
| ever_gt_tfloat_float | temp |
| ever_gt_tint_int | temp |
| ever_gt_ttext_text | temp, txt |
| ever_le_base_temporal | temp |
| ever_le_bigint_tbigint | temp |
| ever_le_float_tfloat | temp |
| ever_le_int_tint | temp |
| ever_le_tbigint_bigint | temp |
| ever_le_temporal_base | temp |
| ever_le_temporal_temporal | temp1, temp2 |
| ever_le_text_ttext | txt, temp |
| ever_le_tfloat_float | temp |
| ever_le_tint_int | temp |
| ever_le_ttext_text | temp, txt |
| ever_lt_base_temporal | temp |
| ever_lt_bigint_tbigint | temp |
| ever_lt_float_tfloat | temp |
| ever_lt_int_tint | temp |
| ever_lt_tbigint_bigint | temp |
| ever_lt_temporal_base | temp |
| ever_lt_temporal_temporal | temp1, temp2 |
| ever_lt_text_ttext | txt, temp |
| ever_lt_tfloat_float | temp |
| ever_lt_tint_int | temp |
| ever_lt_ttext_text | temp, txt |
| ever_ne_base_temporal | temp |
| ever_ne_bigint_tbigint | temp |
| ever_ne_bool_tbool | temp |
| ever_ne_cbuffer_tcbuffer | cb, temp |
| ever_ne_float_tfloat | temp |
| ever_ne_geo_tgeo | gs, temp |
| ever_ne_geo_trgeometry | gs, temp |
| ever_ne_h3index_th3index | temp |
| ever_ne_int_tint | temp |
| ever_ne_jsonb_tjsonb | jb, temp |
| ever_ne_npoint_tnpoint | np, temp |
| ever_ne_pcpatch_tpcpatch | pa, temp |
| ever_ne_pcpoint_tpcpoint | pt, temp |
| ever_ne_pose_tpose | pose, temp |
| ever_ne_posechain_tposechain | posechain, temp |
| ever_ne_quadbin_tquadbin | temp |
| ever_ne_s2cell_ts2cell | temp |
| ever_ne_tbigint_bigint | temp |
| ever_ne_tbool_bool | temp |
| ever_ne_tcbuffer_cbuffer | temp, cb |
| ever_ne_tcbuffer_tcbuffer | temp1, temp2 |
| ever_ne_temporal_base | temp |
| ever_ne_temporal_temporal | temp1, temp2 |
| ever_ne_text_ttext | txt, temp |
| ever_ne_tfloat_float | temp |
| ever_ne_tgeo_geo | temp, gs |
| ever_ne_tgeo_tgeo | temp1, temp2 |
| ever_ne_th3index_h3index | temp |
| ever_ne_th3index_th3index | temp1, temp2 |
| ever_ne_tint_int | temp |
| ever_ne_tjsonb_jsonb | temp, jb |
| ever_ne_tjsonb_tjsonb | temp1, temp2 |
| ever_ne_tnpoint_npoint | temp, np |
| ever_ne_tnpoint_tnpoint | temp1, temp2 |
| ever_ne_tpcpatch_pcpatch | temp, pa |
| ever_ne_tpcpatch_tpcpatch | temp1, temp2 |
| ever_ne_tpcpoint_pcpoint | temp, pt |
| ever_ne_tpcpoint_tpcpoint | temp1, temp2 |
| ever_ne_tpose_pose | temp, pose |
| ever_ne_tpose_tpose | temp1, temp2 |
| ever_ne_tposechain_posechain | temp, posechain |
| ever_ne_tposechain_tposechain | temp1, temp2 |
| ever_ne_tquadbin_quadbin | temp |
| ever_ne_tquadbin_tquadbin | temp1, temp2 |
| ever_ne_trgeometry_geo | temp, gs |
| ever_ne_trgeometry_trgeometry | temp1, temp2 |
| ever_ne_ts2cell_s2cell | temp |
| ever_ne_ts2cell_ts2cell | temp1, temp2 |
| ever_ne_ttext_text | temp, txt |
| float4_in | num |
| float8_in | str |
| float_set_tbox | box |
| float_tstzspan_to_tbox | s |
| float_union_transfn | state |
| floatset_ceil | s |
| floatset_degrees | s |
| floatset_end_value | s |
| floatset_floor | s |
| floatset_in | str |
| floatset_make | values |
| floatset_out | set |
| floatset_radians | s |
| floatset_shift_scale | s |
| floatset_start_value | s |
| floatset_to_intset | s |
| floatset_value_n | s, result |
| floatset_values | s, count |
| floatspan_bins | s, count |
| floatspan_ceil | s |
| floatspan_degrees | s |
| floatspan_expand | s |
| floatspan_floor | s |
| floatspan_in | str |
| floatspan_lower | s |
| floatspan_out | s |
| floatspan_radians | s |
| floatspan_round | s |
| floatspan_round_set | s, result |
| floatspan_set_bigintspan | s1, s2 |
| floatspan_set_intspan | s1, s2 |
| floatspan_shift_scale | s |
| floatspan_to_bigintspan | s |
| floatspan_to_intspan | s |
| floatspan_upper | s |
| floatspan_width | s |
| floatspanset_bins | ss, count |
| floatspanset_ceil | ss |
| floatspanset_degrees | ss |
| floatspanset_floor | ss |
| floatspanset_in | str |
| floatspanset_lower | ss |
| floatspanset_out | ss |
| floatspanset_radians | ss |
| floatspanset_round | ss |
| floatspanset_shift_scale | ss |
| floatspanset_to_intspanset | ss |
| floatspanset_upper | ss |
| floatspanset_width | ss |
| front_stbox_stbox | box1, box2 |
| front_stbox_tspatial | box, temp |
| front_tpcbox_tpcbox | box1, box2 |
| front_tspatial_stbox | temp, box |
| front_tspatial_tspatial | temp1, temp2 |
| gbox_in | str |
| gbox_out | box |
| gbox_set_stbox | box, result |
| gbox_to_stbox | box |
| geo_as_ewkb | gs, endian, size |
| geo_as_ewkt | gs |
| geo_as_geojson | gs |
| geo_as_hexewkb | gs, endian |
| geo_as_text | gs |
| geo_clip_linear_geom | line, gs |
| geo_clip_subject | gs |
| geo_cluster_dbscan | geoms, count |
| geo_cluster_intersecting | geoms, count |
| geo_cluster_kmeans | geoms, count |
| geo_cluster_within | geoms, count |
| geo_collect_garray | gsarr |
| geo_copy | gs |
| geo_covers2d | gs1, gs2 |
| geo_edge_ctx_free | ctx |
| geo_edge_ctx_make | gs |
| geo_equals | gs1, gs2 |
| geo_every_part_bounds_area | gs |
| geo_from_ewkb | wkb |
| geo_from_geojson | geojson |
| geo_from_text | wkt |
| geo_geo_n | geom |
| geo_intersects2d | gs1, gs2 |
| geo_intersects2d_ctx | gs, ctx |
| geo_is_empty | gs |
| geo_is_planar_areal | gs |
| geo_is_planar_linear | gs |
| geo_is_point_set | gs |
| geo_is_unitary | gs |
| geo_makeline_garray | gsarr |
| geo_meos_coverage | gs |
| geo_num_geos | gs |
| geo_num_points | gs |
| geo_out | gs |
| geo_pointarr | gs, count |
| geo_points | gs |
| geo_points_covered | pts, gs |
| geo_reverse | gs |
| geo_round | gs |
| geo_same | gs1, gs2 |
| geo_set_srid | gs |
| geo_set_stbox | gs, result |
| geo_split_each_n_stboxes | gs, count |
| geo_split_n_stboxes | gs, count |
| geo_srid | gs |
| geo_stboxes | gs, count |
| geo_timestamptz_to_stbox | gs |
| geo_to_h3index_cell | point |
| geo_to_h3index_set | gs |
| geo_to_quadbin_cell | point |
| geo_to_s2cell_cell | point |
| geo_to_set | gs |
| geo_to_stbox | gs |
| geo_transform | geom |
| geo_transform_pipeline | gs, pipeline |
| geo_tstzspan_to_stbox | gs, s |
| geo_union_transfn | state, gs |
| geoarr_set_stbox | values, result |
| geog_area | gs |
| geog_array_union | gsarr |
| geog_centroid | gs |
| geog_distance | g1, g2 |
| geog_dwithin | g1, g2 |
| geog_from_hexewkb | wkt |
| geog_in | str |
| geog_intersects | gs1, gs2 |
| geog_length | gs |
| geog_perimeter | gs |
| geog_to_geom | geog |
| geogset_in | str |
| geom_area | gs |
| geom_array_union | gsarr |
| geom_azimuth | gs1, gs2, result |
| geom_boundary | gs |
| geom_buffer | gs, params |
| geom_centroid | gs |
| geom_contains | gs1, gs2 |
| geom_convex_hull | gs |
| geom_covers | gs1, gs2 |
| geom_difference2d | gs1, gs2 |
| geom_disjoint2d | gs1, gs2 |
| geom_distance2d | gs1, gs2 |
| geom_distance3d | gs1, gs2 |
| geom_dwithin | gs1, gs2 |
| geom_dwithin2d | gs1, gs2 |
| geom_dwithin3d | gs1, gs2 |
| geom_from_hexewkb | wkt |
| geom_in | str |
| geom_intersection2d | gs1, gs2 |
| geom_intersection2d_coll | gs1, gs2 |
| geom_intersects | gs1, gs2 |
| geom_intersects2d | gs1, gs2 |
| geom_intersects3d | gs1, gs2 |
| geom_is_simple | gs |
| geom_length | gs |
| geom_max_distance2d | gs1, gs2 |
| geom_meos_coverage | geom |
| geom_min_bounding_radius | geom, radius |
| geom_oriented_envelope | gs |
| geom_perimeter | gs |
| geom_relate | gs1, gs2 |
| geom_relate_pattern | gs1, gs2, patt |
| geom_shortestline2d | gs1, gs2 |
| geom_shortestline3d | gs1, gs2 |
| geom_to_cbuffer | gs |
| geom_to_geog | geom |
| geom_to_nsegment | gs |
| geom_touches | gs1, gs2 |
| geom_unary_union | gs |
| geomeas_to_tpoint | gs |
| geometry_tpose_to_trgeometry | gs, temp |
| geompoint_to_npoint | gs |
| geomset_in | str |
| geopose_frames | count |
| geoset_end_value | s |
| geoset_make | values |
| geoset_start_value | s |
| geoset_value_n | s, result |
| geoset_values | s, count |
| h3_compact_cells | cells |
| h3_uncompact_cells | cells |
| h3index_as_hexwkb | size_out |
| h3index_as_wkb | size_out |
| h3index_from_hexwkb | hexwkb |
| h3index_from_wkb | wkb |
| h3index_in | str |
| h3index_tstzspan_to_stbox | s |
| int16_in | str |
| int32_in | str |
| int64_in | str |
| int_set_tbox | box |
| int_tstzspan_to_tbox | s |
| int_union_transfn | state |
| inter_span_span | s1, s2, result |
| inter_stbox_stbox | box1, box2, result |
| inter_tbox_tbox | box1, box2, result |
| inter_tpcbox_tpcbox | box1, box2, result |
| interptype_from_string | interp_str |
| intersection_bigint_set | s |
| intersection_cbuffer_set | cb, s |
| intersection_date_set | s |
| intersection_float_set | s |
| intersection_geo_set | gs, s |
| intersection_int_set | s |
| intersection_jsonb_set | jb, s |
| intersection_npoint_set | np, s |
| intersection_pcpatch_set | pa, s |
| intersection_pcpoint_set | pt, s |
| intersection_pose_set | pose, s |
| intersection_posechain_set | pc, s |
| intersection_set_bigint | s |
| intersection_set_cbuffer | s, cb |
| intersection_set_date | s |
| intersection_set_float | s |
| intersection_set_geo | s, gs |
| intersection_set_int | s |
| intersection_set_jsonb | s, jb |
| intersection_set_npoint | s, np |
| intersection_set_pcpatch | s, pa |
| intersection_set_pcpoint | s, pt |
| intersection_set_pose | s, pose |
| intersection_set_posechain | s, pc |
| intersection_set_set | s1, s2 |
| intersection_set_text | s, txt |
| intersection_set_timestamptz | s |
| intersection_set_value | s |
| intersection_span_bigint | s |
| intersection_span_date | s |
| intersection_span_float | s |
| intersection_span_int | s |
| intersection_span_span | s1, s2 |
| intersection_span_spanset | s, ss |
| intersection_span_timestamptz | s |
| intersection_span_value | s |
| intersection_spanset_bigint | ss |
| intersection_spanset_date | ss |
| intersection_spanset_float | ss |
| intersection_spanset_int | ss |
| intersection_spanset_span | ss, s |
| intersection_spanset_spanset | ss1, ss2 |
| intersection_spanset_timestamptz | ss |
| intersection_spanset_value | ss |
| intersection_stbox_stbox | box1, box2 |
| intersection_tbox_tbox | box1, box2 |
| intersection_text_set | txt, s |
| intersection_timestamptz_set | s |
| intersection_tpcbox_tpcbox | box1, box2 |
| intersection_value_set | s |
| intersection_value_span | s |
| intersection_value_spanset | ss |
| intersects_cbuffer_cbuffer | cb1, cb2 |
| interval_cmp | interv1, interv2 |
| interval_copy | interv |
| interval_eq | interv1, interv2 |
| interval_extract | interv, units |
| interval_ge | interv1, interv2 |
| interval_gt | interv1, interv2 |
| interval_hash | interv |
| interval_hash_extended | interv |
| interval_in | str |
| interval_is_finite | interv |
| interval_justify_days | interv |
| interval_justify_hours | interv |
| interval_justify_interval | interv |
| interval_larger | interv1, interv2 |
| interval_le | interv1, interv2 |
| interval_lt | interv1, interv2 |
| interval_ne | interv1, interv2 |
| interval_negate | interv |
| interval_out | interv |
| interval_part | interv, units |
| interval_scale | interv |
| interval_smaller | interv1, interv2 |
| interval_to_time | interv |
| interval_trunc | interv, units |
| intset_end_value | s |
| intset_in | str |
| intset_make | values |
| intset_out | set |
| intset_shift_scale | s |
| intset_start_value | s |
| intset_to_floatset | s |
| intset_value_n | s, result |
| intset_values | s, count |
| intspan_bins | s, count |
| intspan_expand | s |
| intspan_in | str |
| intspan_lower | s |
| intspan_out | s |
| intspan_set_bigintspan | s1, s2 |
| intspan_set_floatspan | s1, s2 |
| intspan_shift_scale | s |
| intspan_to_bigintspan | s |
| intspan_to_floatspan | s |
| intspan_upper | s |
| intspan_width | s |
| intspanset_bins | ss, count |
| intspanset_in | str |
| intspanset_lower | ss |
| intspanset_out | ss |
| intspanset_shift_scale | ss |
| intspanset_to_floatspanset | ss |
| intspanset_upper | ss |
| intspanset_width | ss |
| json_array_element | js |
| json_array_element_text | js |
| json_array_elements | js, count |
| json_array_elements_text | js, count |
| json_array_length | js |
| json_each | js, values, count |
| json_each_text | js, values, count |
| json_extract_path | js, path_elems |
| json_extract_path_text | js, path_elems |
| json_in | str |
| json_make | keys_vals |
| json_make_two_arg | keys, values |
| json_object_field | js, key |
| json_object_field_text | js, key |
| json_object_keys | js, count |
| json_out | js |
| json_strip_nulls | js |
| json_typeof | js |
| jsonb_array_element | jb |
| jsonb_array_element_text | jb |
| jsonb_array_elements | jb, count |
| jsonb_array_elements_text | jb, count |
| jsonb_array_length | jb |
| jsonb_cmp | jb1, jb2 |
| jsonb_concat | jb1, jb2 |
| jsonb_contained | jb1, jb2 |
| jsonb_contains | jb1, jb2 |
| jsonb_copy | jb |
| jsonb_delete | jb, key |
| jsonb_delete_array | jb, keys_elems |
| jsonb_delete_index | jb |
| jsonb_delete_path | jb, path_elems |
| jsonb_each | jb, values, count |
| jsonb_each_text | jb, values, count |
| jsonb_eq | jb1, jb2 |
| jsonb_exists | jb, key |
| jsonb_exists_array | jb, keys_elems |
| jsonb_extract_path | jb, path_elems |
| jsonb_extract_path_text | jb, path_elems |
| jsonb_from_text | txt |
| jsonb_ge | jb1, jb2 |
| jsonb_gt | jb1, jb2 |
| jsonb_hash | jb |
| jsonb_hash_extended | jb |
| jsonb_in | str |
| jsonb_insert | jb, path_elems, newjb |
| jsonb_le | jb1, jb2 |
| jsonb_lt | jb1, jb2 |
| jsonb_make | keys_vals |
| jsonb_make_two_arg | keys, values |
| jsonb_ne | jb1, jb2 |
| jsonb_object_field | jb, key |
| jsonb_object_field_text | jb, key |
| jsonb_object_keys | jb, count |
| jsonb_out | jb |
| jsonb_path_exists | jb, jp, vars |
| jsonb_path_match | jb, jp, vars |
| jsonb_path_query_all | jb, jp, vars, count |
| jsonb_path_query_array | jb, jp, vars |
| jsonb_path_query_first | jb, jp, vars |
| jsonb_pretty | jb |
| jsonb_set | jb, path_elems, newjb |
| jsonb_set_lax | jb, path_elems, newjb, handle_null |
| jsonb_strip_nulls | jb |
| jsonb_to_bool | jb |
| jsonb_to_cstring | jb |
| jsonb_to_float4 | jb |
| jsonb_to_float8 | jb |
| jsonb_to_int16 | jb |
| jsonb_to_int32 | jb |
| jsonb_to_int64 | jb |
| jsonb_to_numeric | jb |
| jsonb_to_set | jb |
| jsonb_to_text | jb |
| jsonb_union_transfn | state, jb |
| jsonbset_array_element | set |
| jsonbset_array_length | set |
| jsonbset_delete | set, key |
| jsonbset_delete_array | set, keys |
| jsonbset_delete_index | set |
| jsonbset_delete_path | set, path_elems |
| jsonbset_end_value | s |
| jsonbset_exists | set, key, count |
| jsonbset_exists_array | set, keys, rescount |
| jsonbset_extract_path | set, path_elems |
| jsonbset_in | str |
| jsonbset_insert | set, path_elems, newjb |
| jsonbset_make | values |
| jsonbset_object_field | set, key |
| jsonbset_out | s |
| jsonbset_path_exists | set, jp, count |
| jsonbset_path_match | set, jp, count |
| jsonbset_path_query_array | set, jp |
| jsonbset_path_query_first | set, jp |
| jsonbset_pretty | set |
| jsonbset_set | set, keys, newjb, null_handle |
| jsonbset_start_value | s |
| jsonbset_strip_nulls | set |
| jsonbset_to_alphanumset | set, key |
| jsonbset_to_bigintset | set, key |
| jsonbset_to_floatset | set, key |
| jsonbset_to_intset | set, key |
| jsonbset_to_textset_key | set, key |
| jsonbset_value_n | s, result |
| jsonbset_values | s, count |
| jsonpath_copy | jp |
| jsonpath_in | str |
| jsonpath_out | jp |
| left_bigint_set | s |
| left_bigint_span | s |
| left_bigint_spanset | ss |
| left_float_set | s |
| left_float_span | s |
| left_float_spanset | ss |
| left_int_set | s |
| left_int_span | s |
| left_int_spanset | ss |
| left_numspan_tnumber | s, temp |
| left_set_bigint | s |
| left_set_float | s |
| left_set_int | s |
| left_set_set | s1, s2 |
| left_set_text | s, txt |
| left_set_value | s |
| left_span_bigint | s |
| left_span_float | s |
| left_span_int | s |
| left_span_span | s1, s2 |
| left_span_spanset | s, ss |
| left_span_value | s |
| left_spanset_bigint | ss |
| left_spanset_float | ss |
| left_spanset_int | ss |
| left_spanset_span | ss, s |
| left_spanset_spanset | ss1, ss2 |
| left_spanset_value | ss |
| left_stbox_stbox | box1, box2 |
| left_stbox_tspatial | box, temp |
| left_tbox_tbox | box1, box2 |
| left_tbox_tnumber | box, temp |
| left_text_set | txt, s |
| left_tnumber_numspan | temp, s |
| left_tnumber_tbox | temp, box |
| left_tnumber_tnumber | temp1, temp2 |
| left_tpcbox_tpcbox | box1, box2 |
| left_tspatial_stbox | temp, box |
| left_tspatial_tspatial | temp1, temp2 |
| left_value_set | s |
| left_value_span | s |
| left_value_spanset | ss |
| lfnadj_span_span | s1, s2 |
| line_interpolate_point | gs |
| line_locate_point | gs1, gs2 |
| line_numpoints | gs |
| line_point_n | geom |
| line_substring | gs |
| meos_array_add | array, value |
| meos_array_count | array |
| meos_array_destroy | array |
| meos_array_destroy_free | array |
| meos_array_get | array |
| meos_array_reset | array |
| meos_array_reset_free | array |
| meos_error | format |
| meos_initialize_allocator | malloc_fn, realloc_fn, free_fn |
| meos_initialize_error_handler | err_handler |
| meos_initialize_timezone | name |
| meos_pc_patch_deserialize | serpatch, schema |
| meos_pc_patch_serialize | patch_in, userdata |
| meos_pc_patch_serialize_to_uncompressed | patch_in |
| meos_pc_patch_serialized_size | patch |
| meos_pc_point_deserialize | serpt, schema |
| meos_pc_point_serialize | pcpt |
| meos_pc_schema_from_dims | compression, dims |
| meos_pc_schema_register | schema |
| meos_pc_schema_register_dims | compression, dims |
| meos_pc_schema_register_xml | schema, xml_text |
| meos_random_binomial20_half | rng |
| meos_random_double | rng |
| meos_random_exponential | rng |
| meos_set_datestyle | newval, extra |
| meos_set_intervalstyle | newval |
| meos_set_pointcloud_schemas_xml | path |
| meos_set_spatial_ref_sys_csv | path |
| meos_set_ways_csv | path |
| meos_strtod | str, endptr |
| meos_typeof_hexwkb | hexwkb |
| meosoper_from_string | name |
| mi_span_span | s1, s2, result |
| mindistance_tcbuffer_tcbuffer | temp1, temp2 |
| mindistance_tgeoarr_tgeoarr | arr1, arr2 |
| minus_bigint_set | s |
| minus_bigint_span | s |
| minus_bigint_spanset | ss |
| minus_cbuffer_set | cb, s |
| minus_date_interval | span |
| minus_date_set | s |
| minus_date_span | s |
| minus_date_spanset | ss |
| minus_float_set | s |
| minus_float_span | s |
| minus_float_spanset | ss |
| minus_geo_set | gs, s |
| minus_int_set | s |
| minus_int_span | s |
| minus_int_spanset | ss |
| minus_interval_interval | interv1, interv2 |
| minus_jsonb_set | jb, s |
| minus_npoint_set | np, s |
| minus_pcpatch_set | pa, s |
| minus_pcpoint_set | pt, s |
| minus_pose_set | pose, s |
| minus_posechain_set | pc, s |
| minus_set_bigint | s |
| minus_set_cbuffer | s, cb |
| minus_set_date | s |
| minus_set_float | s |
| minus_set_geo | s, gs |
| minus_set_int | s |
| minus_set_jsonb | s, jb |
| minus_set_npoint | s, np |
| minus_set_pcpatch | s, pa |
| minus_set_pcpoint | s, pt |
| minus_set_pose | s, pose |
| minus_set_posechain | s, pc |
| minus_set_set | s1, s2 |
| minus_set_text | s, txt |
| minus_set_timestamptz | s |
| minus_set_value | s |
| minus_span_bigint | s |
| minus_span_date | s |
| minus_span_float | s |
| minus_span_int | s |
| minus_span_span | s1, s2 |
| minus_span_spanset | s, ss |
| minus_span_timestamptz | s |
| minus_span_value | s |
| minus_spanset_bigint | ss |
| minus_spanset_date | ss |
| minus_spanset_float | ss |
| minus_spanset_int | ss |
| minus_spanset_span | ss, s |
| minus_spanset_spanset | ss1, ss2 |
| minus_spanset_timestamptz | ss |
| minus_spanset_value | ss |
| minus_text_set | txt, s |
| minus_time_interval | interv |
| minus_timestamp_interval | interv |
| minus_timestamptz_interval | interv |
| minus_timestamptz_interval_at_zone | interv, zone |
| minus_timestamptz_set | s |
| minus_timestamptz_span | s |
| minus_timestamptz_spanset | ss |
| minus_timetz_interval | timetz, interv |
| minus_value_set | s |
| minus_value_span | s |
| minus_value_spanset | ss |
| mul_bigint_tbigint | tnumber |
| mul_float8_interval | interv |
| mul_float_tfloat | tnumber |
| mul_int_tint | tnumber |
| mul_interval_float8 | interv |
| mul_tbigint_bigint | tnumber |
| mul_tfloat_float | tnumber |
| mul_tint_int | tnumber |
| mul_tnumber_tnumber | tnumber1, tnumber2 |
| nad_cbuffer_stbox | cb, box |
| nad_stbox_geo | box, gs |
| nad_stbox_stbox | box1, box2 |
| nad_stbox_trgeometry | box, temp |
| nad_tbigint_bigint | temp |
| nad_tbigint_tbigint | temp1, temp2 |
| nad_tbigint_tbox | temp, box |
| nad_tbox_tbox | box1, box2 |
| nad_tboxbigint_tboxbigint | box1, box2 |
| nad_tboxfloat_tboxfloat | box1, box2 |
| nad_tboxint_tboxint | box1, box2 |
| nad_tcbuffer_cbuffer | temp, cb |
| nad_tcbuffer_geo | temp, gs |
| nad_tcbuffer_stbox | temp, box |
| nad_tcbuffer_tcbuffer | temp1, temp2 |
| nad_tfloat_float | temp |
| nad_tfloat_tbox | temp, box |
| nad_tfloat_tfloat | temp1, temp2 |
| nad_tgeo_geo | temp, gs |
| nad_tgeo_stbox | temp, box |
| nad_tgeo_tgeo | temp1, temp2 |
| nad_tint_int | temp |
| nad_tint_tbox | temp, box |
| nad_tint_tint | temp1, temp2 |
| nad_tnpoint_geo | temp, gs |
| nad_tnpoint_npoint | temp, np |
| nad_tnpoint_stbox | temp, box |
| nad_tnpoint_tnpoint | temp1, temp2 |
| nad_tnumber_number | temp |
| nad_tnumber_tbox | temp, box |
| nad_tnumber_tnumber | temp1, temp2 |
| nad_tpcpoint_geo | temp, gs |
| nad_tpose_geo | temp, gs |
| nad_tpose_pose | temp, pose |
| nad_tpose_stbox | temp, box |
| nad_tpose_tpose | temp1, temp2 |
| nad_trgeometry_geo | temp, gs |
| nad_trgeometry_stbox | temp, box |
| nad_trgeometry_tpoint | temp1, temp2 |
| nad_trgeometry_trgeometry | temp1, temp2 |
| nai_tcbuffer_cbuffer | temp, cb |
| nai_tcbuffer_geo | temp, gs |
| nai_tcbuffer_tcbuffer | temp1, temp2 |
| nai_tgeo_geo | temp, gs |
| nai_tgeo_tgeo | temp1, temp2 |
| nai_tnpoint_geo | temp, gs |
| nai_tnpoint_npoint | temp, np |
| nai_tnpoint_tnpoint | temp1, temp2 |
| nai_tpose_geo | temp, gs |
| nai_tpose_pose | temp, pose |
| nai_tpose_tpose | temp1, temp2 |
| nai_trgeometry_geo | temp, gs |
| nai_trgeometry_tpoint | temp1, temp2 |
| nai_trgeometry_trgeometry | temp1, temp2 |
| npoint_as_ewkt | np |
| npoint_as_hexwkb | np, size_out |
| npoint_as_text | np |
| npoint_as_wkb | np, size_out |
| npoint_cmp | np1, np2 |
| npoint_eq | np1, np2 |
| npoint_from_hexwkb | hexwkb |
| npoint_from_wkb | wkb |
| npoint_ge | np1, np2 |
| npoint_gt | np1, np2 |
| npoint_hash | np |
| npoint_hash_extended | np |
| npoint_in | str |
| npoint_le | np1, np2 |
| npoint_lt | np1, np2 |
| npoint_ne | np1, np2 |
| npoint_out | np |
| npoint_position | np |
| npoint_round | np |
| npoint_route | np |
| npoint_same | np1, np2 |
| npoint_srid | np |
| npoint_timestamptz_to_stbox | np |
| npoint_to_geompoint | np |
| npoint_to_nsegment | np |
| npoint_to_set | np |
| npoint_to_stbox | np |
| npoint_tstzspan_to_stbox | np, s |
| npoint_union_transfn | state, np |
| npointset_end_value | s |
| npointset_in | str |
| npointset_make | values |
| npointset_out | s |
| npointset_routes | s |
| npointset_start_value | s |
| npointset_value_n | s, result |
| npointset_values | s, count |
| nsegment_cmp | ns1, ns2 |
| nsegment_end_position | ns |
| nsegment_eq | ns1, ns2 |
| nsegment_ge | ns1, ns2 |
| nsegment_gt | ns1, ns2 |
| nsegment_in | str |
| nsegment_le | ns1, ns2 |
| nsegment_lt | ns1, ns2 |
| nsegment_ne | ns1, ns2 |
| nsegment_out | ns |
| nsegment_round | ns |
| nsegment_route | ns |
| nsegment_srid | ns |
| nsegment_start_position | ns |
| nsegment_to_geom | ns |
| nsegment_to_stbox | ns |
| null_handle_type_from_string | str |
| number_set_tbox | box |
| number_tstzspan_to_tbox | s |
| numset_set_tbox | s, box |
| numset_shift_scale | s |
| numspan_expand | s |
| numspan_set_tbox | span, box |
| numspan_shift_scale | s |
| numspan_timestamptz_to_tbox | span |
| numspan_tstzspan_to_tbox | span, s |
| numspan_width | s |
| numspanset_shift_scale | ss |
| numspanset_width | ss |
| ovadj_span_span | s1, s2 |
| overabove_stbox_stbox | box1, box2 |
| overabove_stbox_tspatial | box, temp |
| overabove_tpcbox_tpcbox | box1, box2 |
| overabove_tspatial_stbox | temp, box |
| overabove_tspatial_tspatial | temp1, temp2 |
| overafter_date_set | s |
| overafter_date_span | s |
| overafter_date_spanset | ss |
| overafter_set_date | s |
| overafter_set_timestamptz | s |
| overafter_span_date | s |
| overafter_span_timestamptz | s |
| overafter_spanset_date | ss |
| overafter_spanset_timestamptz | ss |
| overafter_stbox_stbox | box1, box2 |
| overafter_stbox_tspatial | box, temp |
| overafter_tbox_tbox | box1, box2 |
| overafter_tbox_tnumber | box, temp |
| overafter_temporal_temporal | temp1, temp2 |
| overafter_temporal_tstzspan | temp, s |
| overafter_timestamptz_set | s |
| overafter_timestamptz_span | s |
| overafter_timestamptz_spanset | ss |
| overafter_tnumber_tbox | temp, box |
| overafter_tnumber_tnumber | temp1, temp2 |
| overafter_tpcbox_tpcbox | box1, box2 |
| overafter_tspatial_stbox | temp, box |
| overafter_tspatial_tspatial | temp1, temp2 |
| overafter_tstzspan_temporal | s, temp |
| overback_stbox_stbox | box1, box2 |
| overback_stbox_tspatial | box, temp |
| overback_tpcbox_tpcbox | box1, box2 |
| overback_tspatial_stbox | temp, box |
| overback_tspatial_tspatial | temp1, temp2 |
| overbefore_date_set | s |
| overbefore_date_span | s |
| overbefore_date_spanset | ss |
| overbefore_set_date | s |
| overbefore_set_timestamptz | s |
| overbefore_span_date | s |
| overbefore_span_timestamptz | s |
| overbefore_spanset_date | ss |
| overbefore_spanset_timestamptz | ss |
| overbefore_stbox_stbox | box1, box2 |
| overbefore_stbox_tspatial | box, temp |
| overbefore_tbox_tbox | box1, box2 |
| overbefore_tbox_tnumber | box, temp |
| overbefore_temporal_temporal | temp1, temp2 |
| overbefore_temporal_tstzspan | temp, s |
| overbefore_timestamptz_set | s |
| overbefore_timestamptz_span | s |
| overbefore_timestamptz_spanset | ss |
| overbefore_tnumber_tbox | temp, box |
| overbefore_tnumber_tnumber | temp1, temp2 |
| overbefore_tpcbox_tpcbox | box1, box2 |
| overbefore_tspatial_stbox | temp, box |
| overbefore_tspatial_tspatial | temp1, temp2 |
| overbefore_tstzspan_temporal | s, temp |
| overbelow_stbox_stbox | box1, box2 |
| overbelow_stbox_tspatial | box, temp |
| overbelow_tpcbox_tpcbox | box1, box2 |
| overbelow_tspatial_stbox | temp, box |
| overbelow_tspatial_tspatial | temp1, temp2 |
| overfront_stbox_stbox | box1, box2 |
| overfront_stbox_tspatial | box, temp |
| overfront_tpcbox_tpcbox | box1, box2 |
| overfront_tspatial_stbox | temp, box |
| overfront_tspatial_tspatial | temp1, temp2 |
| overlaps_numspan_tnumber | s, temp |
| overlaps_set_set | s1, s2 |
| overlaps_span_span | s1, s2 |
| overlaps_span_spanset | s, ss |
| overlaps_spanset_span | ss, s |
| overlaps_spanset_spanset | ss1, ss2 |
| overlaps_stbox_stbox | box1, box2 |
| overlaps_stbox_tspatial | box, temp |
| overlaps_tbox_tbox | box1, box2 |
| overlaps_tbox_tnumber | box, temp |
| overlaps_temporal_temporal | temp1, temp2 |
| overlaps_temporal_tstzspan | temp, s |
| overlaps_tnumber_numspan | temp, s |
| overlaps_tnumber_tbox | temp, box |
| overlaps_tnumber_tnumber | temp1, temp2 |
| overlaps_tpcbox_tpcbox | box1, box2 |
| overlaps_tpcbox_tpointcloud | box, temp |
| overlaps_tpointcloud_tpcbox | temp, box |
| overlaps_tpointcloud_tpointcloud | temp1, temp2 |
| overlaps_tspatial_stbox | temp, box |
| overlaps_tspatial_tspatial | temp1, temp2 |
| overlaps_tstzspan_temporal | s, temp |
| overleft_bigint_set | s |
| overleft_bigint_span | s |
| overleft_bigint_spanset | ss |
| overleft_float_set | s |
| overleft_float_span | s |
| overleft_float_spanset | ss |
| overleft_int_set | s |
| overleft_int_span | s |
| overleft_int_spanset | ss |
| overleft_numspan_tnumber | s, temp |
| overleft_set_bigint | s |
| overleft_set_float | s |
| overleft_set_int | s |
| overleft_set_set | s1, s2 |
| overleft_set_text | s, txt |
| overleft_set_value | s |
| overleft_span_bigint | s |
| overleft_span_float | s |
| overleft_span_int | s |
| overleft_span_span | s1, s2 |
| overleft_span_spanset | s, ss |
| overleft_span_value | s |
| overleft_spanset_bigint | ss |
| overleft_spanset_float | ss |
| overleft_spanset_int | ss |
| overleft_spanset_span | ss, s |
| overleft_spanset_spanset | ss1, ss2 |
| overleft_spanset_value | ss |
| overleft_stbox_stbox | box1, box2 |
| overleft_stbox_tspatial | box, temp |
| overleft_tbox_tbox | box1, box2 |
| overleft_tbox_tnumber | box, temp |
| overleft_text_set | txt, s |
| overleft_tnumber_numspan | temp, s |
| overleft_tnumber_tbox | temp, box |
| overleft_tnumber_tnumber | temp1, temp2 |
| overleft_tpcbox_tpcbox | box1, box2 |
| overleft_tspatial_stbox | temp, box |
| overleft_tspatial_tspatial | temp1, temp2 |
| overleft_value_set | s |
| overleft_value_span | s |
| overleft_value_spanset | ss |
| overright_bigint_set | s |
| overright_bigint_span | s |
| overright_bigint_spanset | ss |
| overright_float_set | s |
| overright_float_span | s |
| overright_float_spanset | ss |
| overright_int_set | s |
| overright_int_span | s |
| overright_int_spanset | ss |
| overright_numspan_tnumber | s, temp |
| overright_set_bigint | s |
| overright_set_float | s |
| overright_set_int | s |
| overright_set_set | s1, s2 |
| overright_set_text | s, txt |
| overright_set_value | s |
| overright_span_bigint | s |
| overright_span_float | s |
| overright_span_int | s |
| overright_span_span | s1, s2 |
| overright_span_spanset | s, ss |
| overright_span_value | s |
| overright_spanset_bigint | ss |
| overright_spanset_float | ss |
| overright_spanset_int | ss |
| overright_spanset_span | ss, s |
| overright_spanset_spanset | ss1, ss2 |
| overright_spanset_value | ss |
| overright_stbox_stbox | box1, box2 |
| overright_stbox_tspatial | box, temp |
| overright_tbox_tbox | box1, box2 |
| overright_tbox_tnumber | box, temp |
| overright_text_set | txt, s |
| overright_tnumber_numspan | temp, s |
| overright_tnumber_tbox | temp, box |
| overright_tnumber_tnumber | temp1, temp2 |
| overright_tpcbox_tpcbox | box1, box2 |
| overright_tspatial_stbox | temp, box |
| overright_tspatial_tspatial | temp1, temp2 |
| overright_value_set | s |
| overright_value_span | s |
| overright_value_spanset | ss |
| pcpatch_as_hexwkb | pa |
| pcpatch_cmp | pa1, pa2 |
| pcpatch_copy | pa |
| pcpatch_eq | pa1, pa2 |
| pcpatch_from_hexwkb | hexwkb |
| pcpatch_ge | pa1, pa2 |
| pcpatch_get_pcid | pa |
| pcpatch_gt | pa1, pa2 |
| pcpatch_hash | pa |
| pcpatch_hash_extended | pa |
| pcpatch_hex_in | str |
| pcpatch_hex_out | pa |
| pcpatch_le | pa1, pa2 |
| pcpatch_lt | pa1, pa2 |
| pcpatch_make | points |
| pcpatch_make_coords | values |
| pcpatch_ne | pa1, pa2 |
| pcpatch_npoints | pa |
| pcpatch_point_n | pa |
| pcpatch_points | pa, count |
| pcpatch_to_geom | pa |
| pcpatch_to_set | pa |
| pcpatch_to_tpcbox | pa |
| pcpatch_union_transfn | state, pa |
| pcpatchset_end_value | s |
| pcpatchset_in | str |
| pcpatchset_make | values |
| pcpatchset_out | s |
| pcpatchset_start_value | s |
| pcpatchset_value_n | s, result |
| pcpatchset_values | s, count |
| pcpoint_as_hexwkb | pt |
| pcpoint_cmp | pt1, pt2 |
| pcpoint_copy | pt |
| pcpoint_eq | pt1, pt2 |
| pcpoint_from_hexwkb | hexwkb |
| pcpoint_ge | pt1, pt2 |
| pcpoint_get_dim | pt, schema, name, out |
| pcpoint_get_pcid | pt |
| pcpoint_get_x | pt, schema, out |
| pcpoint_get_y | pt, schema, out |
| pcpoint_get_z | pt, schema, out |
| pcpoint_gt | pt1, pt2 |
| pcpoint_hash | pt |
| pcpoint_hash_extended | pt |
| pcpoint_hex_in | str |
| pcpoint_hex_out | pt |
| pcpoint_le | pt1, pt2 |
| pcpoint_lt | pt1, pt2 |
| pcpoint_make | values |
| pcpoint_ne | pt1, pt2 |
| pcpoint_to_set | pt |
| pcpoint_to_tpcbox | pt, schema |
| pcpoint_union_transfn | state, pt |
| pcpointset_end_value | s |
| pcpointset_in | str |
| pcpointset_make | values |
| pcpointset_out | s |
| pcpointset_start_value | s |
| pcpointset_value_n | s, result |
| pcpointset_values | s, count |
| pg_cstring_to_text | str |
| pg_date_in | str |
| pg_interval_cmp | interv1, interv2 |
| pg_interval_eq | interv1, interv2 |
| pg_interval_ge | interv1, interv2 |
| pg_interval_gt | interv1, interv2 |
| pg_interval_hash | interv |
| pg_interval_hash_extended | interv |
| pg_interval_in | str |
| pg_interval_justify_days | interv |
| pg_interval_justify_hours | interv |
| pg_interval_justify_interval | interv |
| pg_interval_larger | interv1, interv2 |
| pg_interval_le | interv1, interv2 |
| pg_interval_lt | interv1, interv2 |
| pg_interval_ne | interv1, interv2 |
| pg_interval_out | interv |
| pg_interval_part | interv, units |
| pg_interval_scale | interv |
| pg_interval_smaller | interv1, interv2 |
| pg_interval_trunc | interv, units |
| pg_json_array_element | js |
| pg_json_array_element_text | js |
| pg_json_array_elements | js, count |
| pg_json_array_elements_text | js, count |
| pg_json_array_length | js |
| pg_json_each | js, values, count |
| pg_json_each_text | js, values, count |
| pg_json_extract_path | js, path_elems |
| pg_json_extract_path_text | js, path_elems |
| pg_json_in | str |
| pg_json_make | keyvalarr |
| pg_json_make_two_arg | keys, values |
| pg_json_object_field | js, key |
| pg_json_object_field_text | js, key |
| pg_json_object_keys | js, count |
| pg_json_out | js |
| pg_json_strip_nulls | js |
| pg_json_typeof | js |
| pg_jsonb_array_element | jb |
| pg_jsonb_array_element_text | jb |
| pg_jsonb_array_elements | jb, count |
| pg_jsonb_array_elements_text | jb, count |
| pg_jsonb_array_length | jb |
| pg_jsonb_cmp | jb1, jb2 |
| pg_jsonb_concat | jb1, jb2 |
| pg_jsonb_contained | jb1, jb2 |
| pg_jsonb_contains | jb1, jb2 |
| pg_jsonb_copy | jb |
| pg_jsonb_delete | jb, key |
| pg_jsonb_delete_array | jb, keys_elems |
| pg_jsonb_delete_index | jb |
| pg_jsonb_delete_path | jb, path_elems |
| pg_jsonb_each | jb, values, count |
| pg_jsonb_each_text | jb, values, count |
| pg_jsonb_eq | jb1, jb2 |
| pg_jsonb_exists | jb, key |
| pg_jsonb_exists_array | jb, keys_elems |
| pg_jsonb_extract_path | jb, path_elems |
| pg_jsonb_extract_path_text | jb, path_elems |
| pg_jsonb_from_text | txt |
| pg_jsonb_ge | jb1, jb2 |
| pg_jsonb_gt | jb1, jb2 |
| pg_jsonb_hash | jb |
| pg_jsonb_hash_extended | jb |
| pg_jsonb_in | str |
| pg_jsonb_insert | jb, path_elems, newjb |
| pg_jsonb_le | jb1, jb2 |
| pg_jsonb_lt | jb1, jb2 |
| pg_jsonb_make | keys_vals |
| pg_jsonb_make_two_arg | keys, values |
| pg_jsonb_ne | jb1, jb2 |
| pg_jsonb_object_field | jb, key |
| pg_jsonb_object_field_text | jb, key |
| pg_jsonb_object_keys | jb, count |
| pg_jsonb_out | jb |
| pg_jsonb_path_exists | jb, jp, vars |
| pg_jsonb_path_match | jb, jp, vars |
| pg_jsonb_path_query_all | jb, jp, vars, count |
| pg_jsonb_path_query_array | jb, jp, vars |
| pg_jsonb_path_query_first | jb, jp, vars |
| pg_jsonb_pretty | jb |
| pg_jsonb_set | jb, path_elems, newjb |
| pg_jsonb_set_lax | jb, path_elems, newjb, handle_null |
| pg_jsonb_strip_nulls | jb |
| pg_jsonb_to_text | jb |
| pg_jsonpath_copy | jp |
| pg_jsonpath_in | str |
| pg_jsonpath_out | jp |
| pg_numeric | num |
| pg_numeric_abs | num |
| pg_numeric_add | num1, num2 |
| pg_numeric_ceil | num |
| pg_numeric_cmp | num1, num2 |
| pg_numeric_div | num1, num2 |
| pg_numeric_div_trunc | num1, num2 |
| pg_numeric_eq | num1, num2 |
| pg_numeric_exp | num |
| pg_numeric_floor | num |
| pg_numeric_gcd | num1, num2 |
| pg_numeric_ge | num1, num2 |
| pg_numeric_gt | num1, num2 |
| pg_numeric_in | str |
| pg_numeric_inc | num |
| pg_numeric_larger | num1, num2 |
| pg_numeric_lcm | num1, num2 |
| pg_numeric_le | num1, num2 |
| pg_numeric_ln | num |
| pg_numeric_log | num1, num2 |
| pg_numeric_lt | num1, num2 |
| pg_numeric_min_scale | num |
| pg_numeric_mod | num1, num2 |
| pg_numeric_mul | num1, num2 |
| pg_numeric_ne | num1, num2 |
| pg_numeric_out | num |
| pg_numeric_round | num |
| pg_numeric_scale | num |
| pg_numeric_sign | num |
| pg_numeric_smaller | num1, num2 |
| pg_numeric_sqrt | num |
| pg_numeric_sub | num1, num2 |
| pg_numeric_trim_scale | num |
| pg_numeric_trunc | num |
| pg_numeric_typmodin | tl |
| pg_numeric_uminus | num |
| pg_numeric_uplus | num |
| pg_text_concat | textarr |
| pg_text_concat_ws | textarr, sep |
| pg_text_ge | txt1, txt2 |
| pg_text_gt | txt1, txt2 |
| pg_text_larger | txt1, txt2 |
| pg_text_le | txt1, txt2 |
| pg_text_left | txt |
| pg_text_lt | txt1, txt2 |
| pg_text_pattern_ge | txt1, txt2 |
| pg_text_pattern_gt | txt1, txt2 |
| pg_text_pattern_le | txt1, txt2 |
| pg_text_pattern_lt | txt1, txt2 |
| pg_text_reverse | txt |
| pg_text_right | txt |
| pg_text_smaller | txt1, txt2 |
| pg_text_starts_with | txt1, txt2 |
| pg_text_substr | txt |
| pg_text_substr_no_len | txt |
| pg_text_to_cstring | txt |
| pg_time_in | str |
| pg_time_part | units |
| pg_timestamp_bin | stride |
| pg_timestamp_in | str |
| pg_timestamp_izone | zone |
| pg_timestamp_part | units |
| pg_timestamp_trunc | units |
| pg_timestamp_zone | zone |
| pg_timestamptz_bin | stride |
| pg_timestamptz_in | str |
| pg_timestamptz_izone | zone |
| pg_timestamptz_part | units |
| pg_timestamptz_trunc | units |
| pg_timestamptz_trunc_zone | units, zone |
| pg_timestamptz_zone | zone |
| pg_timetz_at_local | timetz |
| pg_timetz_cmp | timetz1, timetz2 |
| pg_timetz_eq | timetz1, timetz2 |
| pg_timetz_ge | timetz1, timetz2 |
| pg_timetz_gt | timetz1, timetz2 |
| pg_timetz_hash | timetz |
| pg_timetz_hash_extended | timetz |
| pg_timetz_in | str |
| pg_timetz_izone | timetz, zone |
| pg_timetz_larger | timetz1, timetz2 |
| pg_timetz_le | timetz1, timetz2 |
| pg_timetz_lt | timetz1, timetz2 |
| pg_timetz_ne | timetz1, timetz2 |
| pg_timetz_out | timetz |
| pg_timetz_part | timetz, units |
| pg_timetz_scale | timetz |
| pg_timetz_smaller | timetz1, timetz2 |
| pg_timetz_zone | timetz, zone |
| pg_unicode_assigned | txt |
| pg_unicode_is_normalized | txt, fmt |
| pg_unicode_normalize_func | txt, fmt |
| pg_unistr | txt |
| plus_time_interval | interv |
| plus_timetz_interval | timetz, interv |
| point_round | gs |
| pose_angular_distance | pose1, pose2 |
| pose_apply_geo | pose, body |
| pose_as_ewkt | pose |
| pose_as_geopose | pose |
| pose_as_hexwkb | pose, size_out |
| pose_as_text | pose |
| pose_as_wkb | pose, size_out |
| pose_cmp | pose1, pose2 |
| pose_compose | body, frame |
| pose_compose_tpose | body, frame |
| pose_copy | pose |
| pose_eq | pose1, pose2 |
| pose_from_geopose | json |
| pose_from_hexwkb | hexwkb |
| pose_from_wkb | wkb |
| pose_ge | pose1, pose2 |
| pose_gt | pose1, pose2 |
| pose_hash | pose |
| pose_hash_extended | pose |
| pose_in | str |
| pose_inverse | pose |
| pose_le | pose1, pose2 |
| pose_lt | pose1, pose2 |
| pose_make_point2d | gs |
| pose_make_point3d | gs |
| pose_make_point3d_ypr | gs |
| pose_ne | pose1, pose2 |
| pose_normalize | pose |
| pose_nsame | pose1, pose2 |
| pose_out | pose |
| pose_pitch | pose |
| pose_quaternion | pose, count |
| pose_roll | pose |
| pose_round | pose |
| pose_same | pose1, pose2 |
| pose_set_srid | pose |
| pose_srid | pose |
| pose_timestamptz_to_stbox | pose |
| pose_to_point | pose |
| pose_to_posechain | pose |
| pose_to_set | pose |
| pose_to_stbox | pose |
| pose_transform | pose |
| pose_transform_pipeline | pose, pipelinestr |
| pose_tstzspan_to_stbox | pose, s |
| pose_union_transfn | state, pose |
| pose_yaw | pose |
| pose_ypr | pose, count |
| posearr_round | posearr |
| posechain_append | pc, pose |
| posechain_as_ewkt | pc |
| posechain_as_hexwkb | pc, size_out |
| posechain_as_text | pc |
| posechain_as_wkb | pc, size_out |
| posechain_cmp | pc1, pc2 |
| posechain_copy | pc |
| posechain_end_pose | pc |
| posechain_eq | pc1, pc2 |
| posechain_from_hexwkb | hexwkb |
| posechain_from_wkb | wkb |
| posechain_ge | pc1, pc2 |
| posechain_gt | pc1, pc2 |
| posechain_hash | pc |
| posechain_hash_extended | pc |
| posechain_in | str |
| posechain_le | pc1, pc2 |
| posechain_lt | pc1, pc2 |
| posechain_make | poses |
| posechain_ne | pc1, pc2 |
| posechain_nsame | pc1, pc2 |
| posechain_num_poses | pc |
| posechain_out | pc |
| posechain_pose_n | pc |
| posechain_poses | pc, count |
| posechain_prefix_pose | pc |
| posechain_round | pc |
| posechain_same | pc1, pc2 |
| posechain_set_srid | pc |
| posechain_srid | pc |
| posechain_start_pose | pc |
| posechain_timestamptz_to_stbox | pc |
| posechain_to_point | pc |
| posechain_to_pose | pc |
| posechain_to_set | pc |
| posechain_to_stbox | pc |
| posechain_transform | pc |
| posechain_transform_pipeline | pc, pipeline |
| posechain_tstzspan_to_stbox | pc, s |
| posechain_union_transfn | state, pc |
| posechainset_end_value | s |
| posechainset_in | str |
| posechainset_make | values |
| posechainset_out | s |
| posechainset_start_value | s |
| posechainset_value_n | s, result |
| posechainset_values | s, count |
| poseset_end_value | s |
| poseset_in | str |
| poseset_make | values |
| poseset_out | s |
| poseset_start_value | s |
| poseset_value_n | s, result |
| poseset_values | s, count |
| quadbin_cell_sibling | direction |
| quadbin_cell_to_children | count |
| quadbin_cell_to_tile | x, y, z |
| quadbin_in | str |
| quadbin_k_ring | count |
| quadbin_string_to_index | str |
| quadbin_tstzspan_to_stbox | s |
| raquet_as_hexwkb | rq, size_out |
| raquet_as_wkb | rq, size_out |
| raquet_cmp | rq1, rq2 |
| raquet_copy | rq |
| raquet_eq | rq1, rq2 |
| raquet_from_hexwkb | hexwkb |
| raquet_from_wkb | wkb |
| raquet_ge | rq1, rq2 |
| raquet_gt | rq1, rq2 |
| raquet_hash | rq |
| raquet_hash_extended | rq |
| raquet_height | rq |
| raquet_in | str |
| raquet_le | rq1, rq2 |
| raquet_lt | rq1, rq2 |
| raquet_make | pixels |
| raquet_ne | rq1, rq2 |
| raquet_nodata | rq |
| raquet_out | rq |
| raquet_pixels | rq, size_out |
| raquet_pixtype | rq |
| raquet_pixtype_from_string | str |
| raquet_quadbin | rq |
| raquet_read | path |
| raquet_read_bytes | data |
| raquet_to_stbox | rq |
| raquet_width | rq |
| raster_as_hexwkb | rast, size_out |
| raster_as_wkb | rast, size_out |
| raster_at_value | traj, rast, vspan |
| raster_at_value_gdal | traj, path, vspan |
| raster_from_hexwkb | hexwkb |
| raster_from_wkb | wkb |
| raster_minus_value | traj, rast, vspan |
| raster_minus_value_gdal | traj, path, vspan |
| raster_num_bands | rast |
| raster_tile_value | traj, rq |
| raster_tile_value_array | traj, rqarr |
| raster_tile_value_quadbin | traj, pixels |
| raster_value | traj, rast |
| raster_value_gdal | traj, path |
| right_bigint_set | s |
| right_bigint_span | s |
| right_bigint_spanset | ss |
| right_float_set | s |
| right_float_span | s |
| right_float_spanset | ss |
| right_int_set | s |
| right_int_span | s |
| right_int_spanset | ss |
| right_numspan_tnumber | s, temp |
| right_set_bigint | s |
| right_set_float | s |
| right_set_int | s |
| right_set_set | s1, s2 |
| right_set_text | s, txt |
| right_set_value | s |
| right_span_bigint | s |
| right_span_float | s |
| right_span_int | s |
| right_span_span | s1, s2 |
| right_span_spanset | s, ss |
| right_span_value | s |
| right_spanset_bigint | ss |
| right_spanset_float | ss |
| right_spanset_int | ss |
| right_spanset_span | ss, s |
| right_spanset_spanset | ss1, ss2 |
| right_spanset_value | ss |
| right_stbox_stbox | box1, box2 |
| right_stbox_tspatial | box, temp |
| right_tbox_tbox | box1, box2 |
| right_tbox_tnumber | box, temp |
| right_text_set | txt, s |
| right_tnumber_numspan | temp, s |
| right_tnumber_tbox | temp, box |
| right_tnumber_tnumber | temp1, temp2 |
| right_tpcbox_tpcbox | box1, box2 |
| right_tspatial_stbox | temp, box |
| right_tspatial_tspatial | temp1, temp2 |
| right_value_set | s |
| right_value_span | s |
| right_value_spanset | ss |
| rtree_free | rtree |
| rtree_height | rtree |
| rtree_insert | rtree, box |
| rtree_insert_temporal | rtree, temp |
| rtree_insert_temporal_split | rtree, temp |
| rtree_join | rtree1, rtree2, result |
| rtree_load | rtree, boxes, ids |
| rtree_mem_size | rtree |
| rtree_nn_cursor_close | cursor |
| rtree_nn_cursor_next | cursor, id_out, dist_out |
| rtree_nn_cursor_open | rtree, query |
| rtree_num_entries | rtree |
| rtree_search | rtree, query, result |
| rtree_search_temporal | rtree, temp, result |
| rtree_search_temporal_dedup | rtree, temp, result |
| s2cell_cell_to_children | count |
| s2cell_edge_neighbors | count |
| s2cell_in | str |
| s2cell_token_to_cell | token |
| s2cell_tstzspan_to_stbox | s |
| same_numspan_tnumber | s, temp |
| same_span_span | s1, s2 |
| same_stbox_stbox | box1, box2 |
| same_stbox_tspatial | box, temp |
| same_tbox_tbox | box1, box2 |
| same_tbox_tnumber | box, temp |
| same_temporal_temporal | temp1, temp2 |
| same_temporal_tstzspan | temp, s |
| same_tnumber_numspan | temp, s |
| same_tnumber_tbox | temp, box |
| same_tnumber_tnumber | temp1, temp2 |
| same_tpcbox_tpcbox | box1, box2 |
| same_tpcbox_tpointcloud | box, temp |
| same_tpointcloud_tpcbox | temp, box |
| same_tpointcloud_tpointcloud | temp1, temp2 |
| same_tspatial_stbox | temp, box |
| same_tspatial_tspatial | temp1, temp2 |
| same_tstzspan_temporal | s, temp |
| set_as_hexwkb | s, size_out |
| set_as_wkb | s, size_out |
| set_cmp | s1, s2 |
| set_compact | s |
| set_copy | s |
| set_end_value | s |
| set_eq | s1, s2 |
| set_from_hexwkb | hexwkb |
| set_from_wkb | wkb |
| set_ge | s1, s2 |
| set_gt | s1, s2 |
| set_hash | s |
| set_hash_extended | s |
| set_in | str |
| set_le | s1, s2 |
| set_lt | s1, s2 |
| set_make | values |
| set_make_exp | values |
| set_make_free | values |
| set_mem_size | s |
| set_ne | s1, s2 |
| set_num_values | s |
| set_out | s |
| set_round | s |
| set_set_span | s, result |
| set_set_subspan | s, result |
| set_span | s |
| set_spans | s, count |
| set_spanset | s |
| set_split_each_n_spans | s, count |
| set_split_n_spans | s, count |
| set_start_value | s |
| set_to_span | s |
| set_to_spanset | s |
| set_to_tbox | s |
| set_union_finalfn | state |
| set_union_transfn | state, s |
| set_vals | s |
| set_value_n | s, result |
| set_values | s, count |
| shortestline_tcbuffer_cbuffer | temp, cb |
| shortestline_tcbuffer_geo | temp, gs |
| shortestline_tcbuffer_tcbuffer | temp1, temp2 |
| shortestline_tgeo_geo | temp, gs |
| shortestline_tgeo_tgeo | temp1, temp2 |
| shortestline_tnpoint_geo | temp, gs |
| shortestline_tnpoint_npoint | temp, np |
| shortestline_tnpoint_tnpoint | temp1, temp2 |
| shortestline_tpose_geo | temp, gs |
| shortestline_tpose_pose | temp, pose |
| shortestline_tpose_tpose | temp1, temp2 |
| shortestline_trgeometry_geo | temp, gs |
| shortestline_trgeometry_tpoint | temp1, temp2 |
| shortestline_trgeometry_trgeometry | temp1, temp2 |
| skiplist_free | list |
| skiplist_keys_values | list, values |
| skiplist_make | comp_fn, merge_fn |
| skiplist_search | list, key, value |
| skiplist_splice | list, keys, values, func |
| skiplist_values | list |
| span_adjacent | s1, s2 |
| span_as_hexwkb | s, size_out |
| span_as_wkb | s, size_out |
| span_bins | s, count |
| span_cmp | s1, s2 |
| span_contained | s1, s2 |
| span_contains | s1, s2 |
| span_copy | s |
| span_eq | s1, s2 |
| span_expand | s1, s2 |
| span_from_hexwkb | hexwkb |
| span_from_wkb | wkb |
| span_ge | s1, s2 |
| span_gt | s1, s2 |
| span_hash | s |
| span_hash_extended | s |
| span_in | str |
| span_le | s1, s2 |
| span_left | s1, s2 |
| span_lower_inc | s |
| span_lt | s1, s2 |
| span_ne | s1, s2 |
| span_out | s |
| span_overlaps | s1, s2 |
| span_overleft | s1, s2 |
| span_overright | s1, s2 |
| span_right | s1, s2 |
| span_same | s1, s2 |
| span_set | s |
| span_to_spanset | s |
| span_to_tbox | s |
| span_union_transfn | s |
| span_upper_inc | s |
| spanset_as_hexwkb | ss, size_out |
| spanset_as_wkb | ss, size_out |
| spanset_bins | ss, count |
| spanset_cmp | ss1, ss2 |
| spanset_compact | ss |
| spanset_copy | ss |
| spanset_end_span | ss |
| spanset_eq | ss1, ss2 |
| spanset_from_hexwkb | hexwkb |
| spanset_from_wkb | wkb |
| spanset_ge | ss1, ss2 |
| spanset_gt | ss1, ss2 |
| spanset_hash | ss |
| spanset_hash_extended | ss |
| spanset_in | str |
| spanset_le | ss1, ss2 |
| spanset_lower | ss |
| spanset_lower_inc | ss |
| spanset_lt | ss1, ss2 |
| spanset_make | spans |
| spanset_make_exp | spans |
| spanset_make_free | spans |
| spanset_mem_size | ss |
| spanset_ne | ss1, ss2 |
| spanset_num_spans | ss |
| spanset_out | ss |
| spanset_span | ss |
| spanset_span_n | ss |
| spanset_spanarr | ss, count |
| spanset_spans | ss, count |
| spanset_split_each_n_spans | ss, count |
| spanset_split_n_spans | ss, count |
| spanset_sps | ss, count |
| spanset_start_span | ss |
| spanset_to_tbox | ss |
| spanset_union_transfn | ss |
| spanset_upper | ss |
| spanset_upper_inc | ss |
| spatial_set_stbox | result |
| spatialset_as_ewkt | set |
| spatialset_as_text | set |
| spatialset_out | s |
| spatialset_set_srid | s |
| spatialset_set_stbox | set, result |
| spatialset_srid | s |
| spatialset_to_stbox | s |
| spatialset_transform | s |
| spatialset_transform_pipeline | s, pipelinestr |
| sptree_free | sptree |
| sptree_height | sptree |
| sptree_insert | sptree, box |
| sptree_insert_temporal | sptree, temp |
| sptree_insert_temporal_split | sptree, temp |
| sptree_join | sptree1, sptree2, result |
| sptree_load | sptree, boxes, ids |
| sptree_mem_size | sptree |
| sptree_nn_cursor_close | cursor |
| sptree_nn_cursor_next | cursor, id_out, dist_out |
| sptree_nn_cursor_open | sptree, query |
| sptree_num_entries | sptree |
| sptree_search | sptree, query, result |
| sptree_search_temporal | sptree, temp, result |
| sptree_search_temporal_dedup | sptree, temp, result |
| stbox_above | box1, box2 |
| stbox_adjacent | box1, box2 |
| stbox_after | box1, box2 |
| stbox_area | box |
| stbox_as_hexwkb | box, size_out |
| stbox_as_wkb | box, size_out |
| stbox_back | box1, box2 |
| stbox_before | box1, box2 |
| stbox_below | box1, box2 |
| stbox_cmp | box1, box2 |
| stbox_contained | box1, box2 |
| stbox_contains | box1, box2 |
| stbox_copy | box |
| stbox_eq | box1, box2 |
| stbox_expand | box1, box2 |
| stbox_expand_space | box |
| stbox_expand_space_set | box, result |
| stbox_expand_time | box, interv |
| stbox_from_hexwkb | hexwkb |
| stbox_from_wkb | wkb |
| stbox_front | box1, box2 |
| stbox_ge | box1, box2 |
| stbox_geo | box |
| stbox_get_space | box |
| stbox_get_space_tile | point, sorigin |
| stbox_get_space_time_tile | point, duration, sorigin |
| stbox_get_time_tile | duration |
| stbox_gt | box1, box2 |
| stbox_hash | box |
| stbox_hash_extended | box |
| stbox_hast | box |
| stbox_hasx | box |
| stbox_hasz | box |
| stbox_in | str |
| stbox_isgeodetic | box |
| stbox_le | box1, box2 |
| stbox_left | box1, box2 |
| stbox_lt | box1, box2 |
| stbox_nad | box1, box2 |
| stbox_ne | box1, box2 |
| stbox_out | box |
| stbox_overabove | box1, box2 |
| stbox_overafter | box1, box2 |
| stbox_overback | box1, box2 |
| stbox_overbefore | box1, box2 |
| stbox_overbelow | box1, box2 |
| stbox_overfront | box1, box2 |
| stbox_overlaps | box1, box2 |
| stbox_overleft | box1, box2 |
| stbox_overright | box1, box2 |
| stbox_perimeter | box |
| stbox_quad_split | box, count |
| stbox_right | box1, box2 |
| stbox_round | box |
| stbox_same | box1, box2 |
| stbox_set | s, result |
| stbox_set_box3d | box, result |
| stbox_set_gbox | box, result |
| stbox_set_srid | box |
| stbox_shift_scale_time | box |
| stbox_space_tiles | bounds, sorigin, count |
| stbox_space_time_tiles | bounds, sorigin, count |
| stbox_spatial_distance | box1, box2 |
| stbox_srid | box |
| stbox_time_tiles | bounds, count |
| stbox_tmax | box, result |
| stbox_tmax_inc | box, result |
| stbox_tmin | box, result |
| stbox_tmin_inc | box, result |
| stbox_to_box3d | box |
| stbox_to_gbox | box |
| stbox_to_geo | box |
| stbox_to_tstzspan | box |
| stbox_transform | box |
| stbox_transform_pipeline | box, pipelinestr |
| stbox_volume | box |
| stbox_xmax | box, result |
| stbox_xmin | box, result |
| stbox_ymax | box, result |
| stbox_ymin | box, result |
| stbox_zmax | box, result |
| stbox_zmin | box, result |
| stboxarr_round | boxarr |
| sub_bigint_tbigint | tnumber |
| sub_float_tfloat | tnumber |
| sub_int_tint | tnumber |
| sub_tbigint_bigint | tnumber |
| sub_tfloat_float | tnumber |
| sub_tint_int | tnumber |
| sub_tnumber_tnumber | tnumber1, tnumber2 |
| super_union_span_span | s1, s2 |
| tand_bool_tbool | temp |
| tand_tbool_bool | temp |
| tand_tbool_tbool | temp1, temp2 |
| tbigint_end_value | temp |
| tbigint_from_base_temp | temp |
| tbigint_from_mfjson | str |
| tbigint_in | str |
| tbigint_max_value | temp |
| tbigint_min_value | temp |
| tbigint_out | temp |
| tbigint_scale_value | temp |
| tbigint_shift_scale_value | temp |
| tbigint_shift_value | temp |
| tbigint_start_value | temp |
| tbigint_tmax_combinefn | state1, state2 |
| tbigint_tmax_transfn | state, temp |
| tbigint_tmin_combinefn | state1, state2 |
| tbigint_tmin_transfn | state, temp |
| tbigint_to_tfloat | temp |
| tbigint_to_th3index | temp |
| tbigint_to_tint | temp |
| tbigint_to_tquadbin | temp |
| tbigint_to_ts2cell | temp |
| tbigint_tsum_combinefn | state1, state2 |
| tbigint_tsum_transfn | state, temp |
| tbigint_value_at_timestamptz | temp, value |
| tbigint_value_n | temp, result |
| tbigint_values | temp, count |
| tbigint_wmax_transfn | state, temp, interv |
| tbigint_wmin_transfn | state, temp, interv |
| tbigint_wsum_transfn | state, temp, interv |
| tbigintbox_expand | box |
| tbigintbox_shift_scale | box |
| tbigintinst_from_mfjson | mfjson |
| tbigintinst_in | str |
| tbigintseq_from_base_tstzset | s |
| tbigintseq_from_base_tstzspan | s |
| tbigintseq_from_mfjson | mfjson |
| tbigintseqset_from_base_tstzspanset | ss |
| tbigintseqset_from_mfjson | mfjson |
| tbigintseqset_in | str |
| tbool_at_value | temp |
| tbool_end_value | temp |
| tbool_from_base_temp | temp |
| tbool_from_mfjson | str |
| tbool_in | str |
| tbool_minus_value | temp |
| tbool_out | temp |
| tbool_start_value | temp |
| tbool_tand_combinefn | state1, state2 |
| tbool_tand_transfn | state, temp |
| tbool_to_tint | temp |
| tbool_tor_combinefn | state1, state2 |
| tbool_tor_transfn | state, temp |
| tbool_value_at_timestamptz | temp, value |
| tbool_value_n | temp, result |
| tbool_values | temp, count |
| tbool_when_true | temp |
| tboolinst_from_mfjson | mfjson |
| tboolinst_in | str |
| tboolseq_from_base_tstzset | s |
| tboolseq_from_base_tstzspan | s |
| tboolseq_from_mfjson | mfjson |
| tboolseq_in | str |
| tboolseqset_from_base_tstzspanset | ss |
| tboolseqset_from_mfjson | mfjson |
| tboolseqset_in | str |
| tbox_adjacent | box1, box2 |
| tbox_after | box1, box2 |
| tbox_as_hexwkb | box, size_out |
| tbox_as_wkb | box, size_out |
| tbox_before | box1, box2 |
| tbox_cmp | box1, box2 |
| tbox_contained | box1, box2 |
| tbox_contains | box1, box2 |
| tbox_copy | box |
| tbox_eq | box1, box2 |
| tbox_expand | box1, box2 |
| tbox_expand_time | box, interv |
| tbox_expand_value | box |
| tbox_from_hexwkb | hexwkb |
| tbox_from_wkb | wkb |
| tbox_ge | box1, box2 |
| tbox_get_value_time_tile | duration |
| tbox_gt | box1, box2 |
| tbox_hash | box |
| tbox_hash_extended | box |
| tbox_hast | box |
| tbox_hasx | box |
| tbox_in | str |
| tbox_le | box1, box2 |
| tbox_left | box1, box2 |
| tbox_lt | box1, box2 |
| tbox_ne | box1, box2 |
| tbox_out | box |
| tbox_overafter | box1, box2 |
| tbox_overbefore | box1, box2 |
| tbox_overlaps | box1, box2 |
| tbox_overleft | box1, box2 |
| tbox_overright | box1, box2 |
| tbox_right | box1, box2 |
| tbox_round | box |
| tbox_same | box1, box2 |
| tbox_set | s, p, box |
| tbox_shift_scale_time | box |
| tbox_shift_scale_value | box |
| tbox_tmax | box, result |
| tbox_tmax_inc | box, result |
| tbox_tmin | box, result |
| tbox_tmin_inc | box, result |
| tbox_to_bigintspan | box |
| tbox_to_floatspan | box |
| tbox_to_intspan | box |
| tbox_to_tstzspan | box |
| tbox_value_time_tiles | box, count |
| tbox_xmax | box, result |
| tbox_xmax_inc | box, result |
| tbox_xmin | box, result |
| tbox_xmin_inc | box, result |
| tboxbigint_xmax | box, result |
| tboxbigint_xmin | box, result |
| tboxfloat_xmax | box, result |
| tboxfloat_xmin | box, result |
| tboxint_xmax | box, result |
| tboxint_xmin | box, result |
| tcbuffer_at_cbuffer | temp, cb |
| tcbuffer_at_geom | temp, gs |
| tcbuffer_at_stbox | temp, box |
| tcbuffer_convex_hull | temp |
| tcbuffer_end_value | temp |
| tcbuffer_expand | temp |
| tcbuffer_from_base_temp | cb, temp |
| tcbuffer_from_mfjson | mfjson |
| tcbuffer_in | str |
| tcbuffer_make | tpoint, tfloat |
| tcbuffer_minus_cbuffer | temp, cb |
| tcbuffer_minus_geom | temp, gs |
| tcbuffer_minus_stbox | temp, box |
| tcbuffer_points | temp |
| tcbuffer_radius | temp |
| tcbuffer_start_value | temp |
| tcbuffer_to_tfloat | temp |
| tcbuffer_to_tgeompoint | temp |
| tcbuffer_traversed_area | temp |
| tcbuffer_value_at_timestamptz | temp, value |
| tcbuffer_value_n | temp, result |
| tcbuffer_values | temp, count |
| tcbufferinst_make | cb |
| tcbufferseq_from_base_tstzset | cb, s |
| tcbufferseq_from_base_tstzspan | cb, s |
| tcbufferseqset_from_base_tstzspanset | cb, ss |
| tcellindex_cell_area | temp |
| tcellindex_cell_to_boundary | temp |
| tcellindex_cell_to_parent | temp |
| tcellindex_cell_to_point | temp |
| tcellindex_get_resolution | temp |
| tcellindex_is_valid_cell | temp |
| tcontains_cbuffer_tcbuffer | cb, temp |
| tcontains_geo_tcbuffer | gs, temp |
| tcontains_geo_tgeo | gs, temp |
| tcontains_tcbuffer_cbuffer | temp, cb |
| tcontains_tcbuffer_geo | temp, gs |
| tcontains_tcbuffer_tcbuffer | temp1, temp2 |
| tcontains_tgeo_geo | temp, gs |
| tcontains_tgeo_tgeo | temp1, temp2 |
| tcontseq_after_timestamptz | seq |
| tcontseq_before_timestamptz | seq |
| tcontseq_restrict_minmax | seq |
| tcovers_cbuffer_tcbuffer | cb, temp |
| tcovers_geo_tcbuffer | gs, temp |
| tcovers_geo_tgeo | gs, temp |
| tcovers_tcbuffer_cbuffer | temp, cb |
| tcovers_tcbuffer_geo | temp, gs |
| tcovers_tcbuffer_tcbuffer | temp1, temp2 |
| tcovers_tgeo_geo | temp, gs |
| tcovers_tgeo_tgeo | temp1, temp2 |
| tdiscseq_after_timestamptz | seq |
| tdiscseq_before_timestamptz | seq |
| tdiscseq_restrict_minmax | seq |
| tdisjoint_cbuffer_tcbuffer | cb, temp |
| tdisjoint_geo_tcbuffer | gs, temp |
| tdisjoint_geo_tgeo | gs, temp |
| tdisjoint_tcbuffer_cbuffer | temp, cb |
| tdisjoint_tcbuffer_geo | temp, gs |
| tdisjoint_tcbuffer_tcbuffer | temp1, temp2 |
| tdisjoint_tgeo_geo | temp, gs |
| tdisjoint_tgeo_tgeo | temp1, temp2 |
| tdisjoint_tgeoarr_tgeoarr | arr1, arr2, count, periods |
| tdistance_tcbuffer_cbuffer | temp, cb |
| tdistance_tcbuffer_geo | temp, gs |
| tdistance_tcbuffer_tcbuffer | temp1, temp2 |
| tdistance_tfloat_float | temp |
| tdistance_tgeo_geo | temp, gs |
| tdistance_tgeo_tgeo | temp1, temp2 |
| tdistance_tint_int | temp |
| tdistance_tnpoint_geo | temp, gs |
| tdistance_tnpoint_npoint | temp, np |
| tdistance_tnpoint_tnpoint | temp1, temp2 |
| tdistance_tnumber_number | temp |
| tdistance_tnumber_tnumber | temp1, temp2 |
| tdistance_tpose_geo | temp, gs |
| tdistance_tpose_pose | temp, pose |
| tdistance_tpose_tpose | temp1, temp2 |
| tdistance_trgeometry_geo | temp, gs |
| tdistance_trgeometry_tpoint | temp1, temp2 |
| tdistance_trgeometry_trgeometry | temp1, temp2 |
| tdwithin_geo_tcbuffer | gs, temp |
| tdwithin_geo_tgeo | gs, temp |
| tdwithin_tcbuffer_cbuffer | temp, cb |
| tdwithin_tcbuffer_geo | temp, gs |
| tdwithin_tcbuffer_tcbuffer | temp1, temp2 |
| tdwithin_tgeo_geo | temp, gs |
| tdwithin_tgeo_tgeo | temp1, temp2 |
| tdwithin_tgeoarr_tgeoarr | arr1, arr2, count, periods |
| temparr_out | temparr |
| temparr_round | temp |
| temporal_after_timestamptz | temp |
| temporal_app_tinst_transfn | inst |
| temporal_app_tseq_transfn | seq |
| temporal_append_tinstant | temp, inst |
| temporal_append_tsequence | temp, seq |
| temporal_as_hexwkb | temp, size_out |
| temporal_as_mfjson | temp |
| temporal_as_tinstant | temp |
| temporal_as_tsequence | temp |
| temporal_as_tsequenceset | temp |
| temporal_as_wkb | temp, size_out |
| temporal_at_max | temp |
| temporal_at_min | temp |
| temporal_at_timestamptz | temp |
| temporal_at_tstzset | temp, s |
| temporal_at_tstzspan | temp, s |
| temporal_at_tstzspanset | temp, ss |
| temporal_at_values | temp, set |
| temporal_average_hausdorff_distance | temp1, temp2 |
| temporal_basetype_name | temp |
| temporal_bbox_cmp | box1, box2 |
| temporal_bbox_eq | box1, box2 |
| temporal_bbox_restrict_set | temp, set |
| temporal_before_timestamptz | temp |
| temporal_cmp | temp1, temp2 |
| temporal_compact | temp |
| temporal_copy | temp |
| temporal_delete_timestamptz | temp |
| temporal_delete_tstzset | temp, s |
| temporal_delete_tstzspan | temp, s |
| temporal_delete_tstzspanset | temp, ss |
| temporal_derivative | temp |
| temporal_duration | temp |
| temporal_dyntimewarp_distance | temp1, temp2 |
| temporal_dyntimewarp_path | temp1, temp2, count |
| temporal_end_inst | temp |
| temporal_end_instant | temp |
| temporal_end_sequence | temp |
| temporal_end_timestamptz | temp |
| temporal_end_value | temp |
| temporal_eq | temp1, temp2 |
| temporal_ext_kalman_filter | temp |
| temporal_extent_transfn | s |
| temporal_frechet_distance | temp1, temp2 |
| temporal_frechet_path | temp1, temp2, count |
| temporal_from_base_temp | temp |
| temporal_from_hexwkb | hexwkb |
| temporal_from_mfjson | mfjson |
| temporal_from_wkb | wkb |
| temporal_ge | temp1, temp2 |
| temporal_gt | temp1, temp2 |
| temporal_hash | temp |
| temporal_hash_extended | temp |
| temporal_hausdorff_distance | temp1, temp2 |
| temporal_in | str |
| temporal_insert | temp1, temp2 |
| temporal_inst_n | temp |
| temporal_instant_n | temp |
| temporal_instants | temp, count |
| temporal_insts_p | temp, count |
| temporal_interp | temp |
| temporal_lcss_distance | temp1, temp2 |
| temporal_le | temp1, temp2 |
| temporal_lower_inc | temp |
| temporal_lt | temp1, temp2 |
| temporal_max_inst_p | temp |
| temporal_max_instant | temp |
| temporal_max_value | temp |
| temporal_mem_size | temp |
| temporal_merge_array | temparr |
| temporal_merge_combinefn | state1, state2 |
| temporal_merge_transfn | state, temp |
| temporal_min_inst_p | temp |
| temporal_min_instant | temp |
| temporal_min_value | temp |
| temporal_minus_max | temp |
| temporal_minus_min | temp |
| temporal_minus_timestamptz | temp |
| temporal_minus_tstzset | temp, s |
| temporal_minus_tstzspan | temp, s |
| temporal_minus_tstzspanset | temp, ss |
| temporal_minus_values | temp, set |
| temporal_ne | temp1, temp2 |
| temporal_num_instants | temp |
| temporal_num_sequences | temp |
| temporal_num_timestamps | temp |
| temporal_out | temp |
| temporal_restart | temp |
| temporal_restrict_minmax | temp |
| temporal_restrict_timestamptz | temp |
| temporal_restrict_tstzset | temp, s |
| temporal_restrict_tstzspan | temp, s |
| temporal_restrict_tstzspanset | temp, ss |
| temporal_restrict_value | temp |
| temporal_restrict_values | temp, set |
| temporal_round | temp |
| temporal_scale_time | temp, duration |
| temporal_segm_duration | temp, duration |
| temporal_segments | temp, count |
| temporal_sequence_n | temp |
| temporal_sequences | temp, count |
| temporal_sequences_p | temp, count |
| temporal_set_bbox | temp, box |
| temporal_set_interp | temp |
| temporal_set_tstzspan | temp, s |
| temporal_shift_scale_time | temp, shift, duration |
| temporal_shift_time | temp, shift |
| temporal_simplify_dp | temp |
| temporal_simplify_max_dist | temp |
| temporal_simplify_min_dist | temp |
| temporal_simplify_min_tdelta | temp, mint |
| temporal_skiplist_splice | list, values, func |
| temporal_spans | temp, count |
| temporal_split_each_n_spans | temp, count |
| temporal_split_n_spans | temp, count |
| temporal_start_inst | temp |
| temporal_start_instant | temp |
| temporal_start_sequence | temp |
| temporal_start_timestamptz | temp |
| temporal_start_value | temp |
| temporal_stops | temp, minduration |
| temporal_subtype | temp |
| temporal_tcount_combinefn | state1, state2 |
| temporal_tcount_transfn | temp |
| temporal_time | temp |
| temporal_time_bins | temp, duration, count |
| temporal_time_overlaps | temp1, temp2 |
| temporal_time_split | temp, duration, bins, count |
| temporal_timestamps | temp, count |
| temporal_timestamptz_n | temp, result |
| temporal_to_tstzspan | temp |
| temporal_tprecision | temp, duration |
| temporal_tsample | temp, duration |
| temporal_tsequence | temp |
| temporal_tsequenceset | temp |
| temporal_update | temp1, temp2 |
| temporal_upper_inc | temp |
| temporal_value_at_timestamptz | temp, result |
| temporal_value_n | temp, result |
| temporal_values | temp, count |
| temporal_values_p | temp, count |
| tempsubtype_from_string | str, subtype |
| teq_base_temporal | temp |
| teq_bigint_tbigint | temp |
| teq_bool_tbool | temp |
| teq_cbuffer_tcbuffer | cb, temp |
| teq_float_tfloat | temp |
| teq_geo_tgeo | gs, temp |
| teq_geo_trgeometry | gs, temp |
| teq_h3index_th3index | temp |
| teq_int_tint | temp |
| teq_jsonb_tjsonb | jb, temp |
| teq_pcpatch_tpcpatch | pa, temp |
| teq_pcpoint_tpcpoint | pt, temp |
| teq_pose_tpose | pose, temp |
| teq_posechain_tposechain | posechain, temp |
| teq_quadbin_tquadbin | temp |
| teq_s2cell_ts2cell | temp |
| teq_tbigint_bigint | temp |
| teq_tbool_bool | temp |
| teq_tcbuffer_cbuffer | temp, cb |
| teq_temporal_base | temp |
| teq_temporal_temporal | temp1, temp2 |
| teq_text_ttext | txt, temp |
| teq_tfloat_float | temp |
| teq_tgeo_geo | temp, gs |
| teq_th3index_h3index | temp |
| teq_th3index_th3index | temp1, temp2 |
| teq_tint_int | temp |
| teq_tjsonb_jsonb | temp, jb |
| teq_tnpoint_npoint | temp, np |
| teq_tpcpatch_pcpatch | temp, pa |
| teq_tpcpoint_pcpoint | temp, pt |
| teq_tpose_pose | temp, pose |
| teq_tposechain_posechain | temp, posechain |
| teq_tquadbin_quadbin | temp |
| teq_tquadbin_tquadbin | temp1, temp2 |
| teq_trgeometry_geo | temp, gs |
| teq_ts2cell_s2cell | temp |
| teq_ts2cell_ts2cell | temp1, temp2 |
| teq_ttext_text | temp, txt |
| text_cat | txt1, txt2 |
| text_cmp | txt1, txt2 |
| text_concat | textarr |
| text_concat_ws | textarr, sep |
| text_copy | txt |
| text_eq | txt1, txt2 |
| text_ge | txt1, txt2 |
| text_gt | txt1, txt2 |
| text_hash | txt |
| text_hash_extended | txt |
| text_in | str |
| text_initcap | txt |
| text_larger | txt1, txt2 |
| text_le | txt1, txt2 |
| text_left | txt |
| text_len | txt |
| text_lower | txt |
| text_lt | txt1, txt2 |
| text_ne | txt1, txt2 |
| text_octetlen | txt |
| text_out | txt |
| text_overlay | txt1, txt2 |
| text_overlay_no_len | txt1, txt2 |
| text_pattern_ge | txt1, txt2 |
| text_pattern_gt | txt1, txt2 |
| text_pattern_le | txt1, txt2 |
| text_pattern_lt | txt1, txt2 |
| text_pos | txt, search |
| text_replace | txt, from, to |
| text_reverse | txt |
| text_right | txt |
| text_smaller | txt1, txt2 |
| text_split_part | txt, sep |
| text_starts_with | txt1, txt2 |
| text_substr | txt |
| text_substr_no_len | txt |
| text_to_cstring | txt |
| text_to_set | txt |
| text_union_transfn | state, txt |
| text_upper | txt |
| textcat_text_text | txt1, txt2 |
| textcat_text_textset | txt, s |
| textcat_text_ttext | txt, temp |
| textcat_textset_text | s, txt |
| textcat_textset_text_common | s, txt |
| textcat_ttext_text | temp, txt |
| textcat_ttext_ttext | temp1, temp2 |
| textset_end_value | s |
| textset_in | str |
| textset_initcap | s |
| textset_lower | s |
| textset_make | values |
| textset_out | set |
| textset_start_value | s |
| textset_upper | s |
| textset_value_n | s, result |
| textset_values | s, count |
| tfloat_at_value | temp |
| tfloat_ceil | temp |
| tfloat_cos | temp |
| tfloat_degrees | temp |
| tfloat_end_value | temp |
| tfloat_exp | temp |
| tfloat_floor | temp |
| tfloat_from_base_temp | temp |
| tfloat_from_mfjson | str |
| tfloat_in | str |
| tfloat_ln | temp |
| tfloat_log10 | temp |
| tfloat_max_value | temp |
| tfloat_min_value | temp |
| tfloat_minus_value | temp |
| tfloat_out | temp |
| tfloat_radians | temp |
| tfloat_scale_value | temp |
| tfloat_shift_scale_value | temp |
| tfloat_shift_value | temp |
| tfloat_sin | temp |
| tfloat_start_value | temp |
| tfloat_tan | temp |
| tfloat_time_boxes | temp, duration, count |
| tfloat_tmax_combinefn | state1, state2 |
| tfloat_tmax_transfn | state, temp |
| tfloat_tmin_combinefn | state1, state2 |
| tfloat_tmin_transfn | state, temp |
| tfloat_to_tbigint | temp |
| tfloat_to_tint | temp |
| tfloat_tsum_combinefn | state1, state2 |
| tfloat_tsum_transfn | state, temp |
| tfloat_value_at_timestamptz | temp, value |
| tfloat_value_bins | temp, count |
| tfloat_value_boxes | temp, count |
| tfloat_value_n | temp, result |
| tfloat_value_split | temp, bins, count |
| tfloat_value_time_boxes | temp, duration, count |
| tfloat_value_time_split | temp, duration, value_bins, time_bins, count |
| tfloat_values | temp, count |
| tfloat_wmax_transfn | state, temp, interv |
| tfloat_wmin_transfn | state, temp, interv |
| tfloat_wsum_transfn | state, temp, interv |
| tfloatbox_expand | box |
| tfloatbox_shift_scale | box |
| tfloatbox_time_tiles | box, duration, count |
| tfloatbox_value_tiles | box, count |
| tfloatbox_value_time_tiles | box, duration, count |
| tfloatinst_from_mfjson | mfjson |
| tfloatinst_in | str |
| tfloatseq_from_base_tstzset | s |
| tfloatseq_from_base_tstzspan | s |
| tfloatseq_from_mfjson | mfjson |
| tfloatseq_in | str |
| tfloatseqset_from_base_tstzspanset | ss |
| tfloatseqset_from_mfjson | mfjson |
| tfloatseqset_in | str |
| tge_base_temporal | temp |
| tge_bigint_tbigint | temp |
| tge_float_tfloat | temp |
| tge_int_tint | temp |
| tge_tbigint_bigint | temp |
| tge_temporal_base | temp |
| tge_temporal_temporal | temp1, temp2 |
| tge_text_ttext | txt, temp |
| tge_tfloat_float | temp |
| tge_tint_int | temp |
| tge_ttext_text | temp, txt |
| tgeo_affine | temp, a |
| tgeo_at_geom | temp, gs |
| tgeo_at_stbox | temp, box |
| tgeo_at_value | temp, gs |
| tgeo_centroid | temp |
| tgeo_convex_hull | temp |
| tgeo_end_value | temp |
| tgeo_from_base_temp | gs, temp |
| tgeo_minus_geom | temp, gs |
| tgeo_minus_stbox | temp, box |
| tgeo_minus_value | temp, gs |
| tgeo_restrict_elevation | temp, s |
| tgeo_restrict_geom | temp, gs |
| tgeo_restrict_stbox | temp, box |
| tgeo_scale | temp, scale |
| tgeo_space_boxes | temp, sorigin, count |
| tgeo_space_split | temp, sorigin |
| tgeo_space_time_boxes | temp, count |
| tgeo_space_time_split | temp, sorigin |
| tgeo_split_each_n_stboxes | temp, count |
| tgeo_split_n_stboxes | temp, count |
| tgeo_start_value | temp |
| tgeo_stboxes | temp, count |
| tgeo_tpoint | temp |
| tgeo_traversed_area | temp |
| tgeo_value_at_timestamptz | temp, result |
| tgeo_value_n | temp, result |
| tgeo_values | temp, count |
| tgeogpoint_from_mfjson | str |
| tgeogpoint_great_circle_distance | a, b |
| tgeogpoint_in | str |
| tgeogpoint_to_tgeography | temp |
| tgeogpoint_to_th3index | temp |
| tgeogpointinst_from_mfjson | mfjson |
| tgeogpointinst_in | str |
| tgeogpointseq_from_mfjson | mfjson |
| tgeogpointseq_in | str |
| tgeogpointseqset_from_mfjson | mfjson |
| tgeogpointseqset_in | str |
| tgeography_from_mfjson | mfjson |
| tgeography_in | str |
| tgeography_to_tgeogpoint | temp |
| tgeography_to_tgeometry | temp |
| tgeographyinst_from_mfjson | mfjson |
| tgeographyinst_in | str |
| tgeographyseq_from_mfjson | mfjson |
| tgeographyseq_in | str |
| tgeographyseqset_from_mfjson | mfjson |
| tgeographyseqset_in | str |
| tgeoinst_make | gs |
| tgeoinst_restrict_geom | inst, gs |
| tgeoinst_restrict_stbox | inst, box |
| tgeoinst_set_stbox | inst, box |
| tgeom_tgeog | temp |
| tgeometry_from_mfjson | str |
| tgeometry_in | str |
| tgeometry_to_tcbuffer | temp |
| tgeometry_to_tgeography | temp |
| tgeometry_to_tgeompoint | temp |
| tgeometryinst_from_mfjson | mfjson |
| tgeometryinst_in | str |
| tgeometryseq_from_mfjson | mfjson |
| tgeometryseq_in | str |
| tgeometryseqset_from_mfjson | mfjson |
| tgeometryseqset_in | str |
| tgeominst_tgeoginst | inst |
| tgeompoint_from_mfjson | str |
| tgeompoint_in | str |
| tgeompoint_to_tgeometry | temp |
| tgeompoint_to_th3index | temp |
| tgeompoint_to_tnpoint | temp |
| tgeompointinst_from_mfjson | mfjson |
| tgeompointinst_in | str |
| tgeompointseq_from_mfjson | mfjson |
| tgeompointseq_in | str |
| tgeompointseqset_from_mfjson | mfjson |
| tgeompointseqset_in | str |
| tgeomseq_tgeogseq | seq |
| tgeomseqset_tgeogseqset | ss |
| tgeoseq_from_base_tstzset | gs, s |
| tgeoseq_from_base_tstzspan | gs, s |
| tgeoseq_restrict_geom | seq, gs |
| tgeoseq_restrict_stbox | seq, box |
| tgeoseq_split_n_stboxes | seq, count |
| tgeoseq_stboxes | seq, count |
| tgeoseqset_from_base_tstzspanset | gs, ss |
| tgeoseqset_restrict_geom | ss, gs |
| tgeoseqset_restrict_stbox | ss, box |
| tgeoseqset_split_n_stboxes | ss, count |
| tgeoseqset_stboxes | ss, count |
| tgt_base_temporal | temp |
| tgt_bigint_tbigint | temp |
| tgt_float_tfloat | temp |
| tgt_int_tint | temp |
| tgt_tbigint_bigint | temp |
| tgt_temporal_base | temp |
| tgt_temporal_temporal | temp1, temp2 |
| tgt_text_ttext | txt, temp |
| tgt_tfloat_float | temp |
| tgt_tint_int | temp |
| tgt_ttext_text | temp, txt |
| th3index_are_neighbor_cells | origin, dest |
| th3index_cell_to_center_child | temp |
| th3index_cell_to_center_child_next | temp |
| th3index_cell_to_child_pos | temp |
| th3index_cell_to_local_ij | origin, cell |
| th3index_cell_to_parent_next | temp |
| th3index_cell_to_vertex | temp |
| th3index_cells_to_directed_edge | origin, dest |
| th3index_child_pos_to_cell | child_pos, parent |
| th3index_directed_edge_to_boundary | edge |
| th3index_edge_length | temp |
| th3index_end_value | temp |
| th3index_get_base_cell_number | temp |
| th3index_get_directed_edge_destination | edge |
| th3index_get_directed_edge_origin | edge |
| th3index_grid_distance | origin, dest |
| th3index_in | str |
| th3index_is_pentagon | temp |
| th3index_is_res_class_iii | temp |
| th3index_is_valid_directed_edge | edge |
| th3index_is_valid_vertex | temp |
| th3index_local_ij_to_cell | origin, coord |
| th3index_start_value | temp |
| th3index_to_tbigint | temp |
| th3index_to_tgeogpoint | temp |
| th3index_to_tgeompoint | temp |
| th3index_value_at_timestamptz | temp, result |
| th3index_value_n | temp, result |
| th3index_values | temp, count |
| th3index_vertex_to_latlng | temp |
| th3indexinst_in | str |
| th3indexseq_in | str |
| th3indexseq_make | values, times |
| th3indexseqset_in | str |
| th3indexseqset_make | sequences |
| time_extract | units |
| time_in | str |
| time_part | units |
| timestamp_bin | stride |
| timestamp_extract | units |
| timestamp_in | str |
| timestamp_izone | zone |
| timestamp_part | units |
| timestamp_trunc | units |
| timestamp_zone | zone |
| timestamptz_bin | stride |
| timestamptz_extract | units |
| timestamptz_get_bin | duration |
| timestamptz_in | str |
| timestamptz_izone | zone |
| timestamptz_make_at_timezone | zone |
| timestamptz_part | units |
| timestamptz_set_stbox | result |
| timestamptz_set_tbox | box |
| timestamptz_shift | interv |
| timestamptz_tprecision | duration |
| timestamptz_trunc | units |
| timestamptz_trunc_zone | units, zone |
| timestamptz_union_transfn | state |
| timestamptz_zone | zone |
| timetz_at_local | timetz |
| timetz_cmp | timetz1, timetz2 |
| timetz_copy | timetz |
| timetz_eq | timetz1, timetz2 |
| timetz_extract | timetz, units |
| timetz_ge | timetz1, timetz2 |
| timetz_gt | timetz1, timetz2 |
| timetz_hash | timetz |
| timetz_hash_extended | timetz |
| timetz_in | str |
| timetz_izone | timetz, zone |
| timetz_larger | timetz1, timetz2 |
| timetz_le | timetz1, timetz2 |
| timetz_lt | timetz1, timetz2 |
| timetz_ne | timetz1, timetz2 |
| timetz_out | timetz |
| timetz_overlaps | ts1, te1, ts2, te2 |
| timetz_part | timetz, units |
| timetz_scale | timetz |
| timetz_smaller | timetz1, timetz2 |
| timetz_to_time | timetz |
| timetz_zone | timetz, zone |
| tinstant_after_timestamptz | inst |
| tinstant_as_tsequence | inst |
| tinstant_as_tsequenceset | inst |
| tinstant_before_timestamptz | inst |
| tinstant_cmp | inst1, inst2 |
| tinstant_copy | inst |
| tinstant_eq | inst1, inst2 |
| tinstant_from_mfjson | mfjson |
| tinstant_hash | inst |
| tinstant_hash_extended | inst |
| tinstant_in | str |
| tinstant_insts | inst, count |
| tinstant_merge | inst1, inst2 |
| tinstant_merge_array | instants |
| tinstant_out | inst |
| tinstant_restrict_timestamptz | inst |
| tinstant_restrict_tstzset | inst, s |
| tinstant_restrict_tstzspan | inst, period |
| tinstant_restrict_tstzspanset | inst, ss |
| tinstant_restrict_value | inst |
| tinstant_restrict_values | inst, set |
| tinstant_set_bbox | inst, box |
| tinstant_set_tstzspan | inst, s |
| tinstant_shift_time | inst, interv |
| tinstant_time | inst |
| tinstant_timestamps | inst, count |
| tinstant_to_tsequence_free | inst |
| tinstant_value | inst |
| tinstant_value_at_timestamptz | inst, result |
| tinstant_value_p | inst |
| tinstant_values_p | inst, count |
| tint_at_value | temp |
| tint_end_value | temp |
| tint_from_base_temp | temp |
| tint_from_mfjson | str |
| tint_in | str |
| tint_max_value | temp |
| tint_min_value | temp |
| tint_minus_value | temp |
| tint_out | temp |
| tint_scale_value | temp |
| tint_shift_scale_value | temp |
| tint_shift_value | temp |
| tint_start_value | temp |
| tint_time_boxes | temp, duration, count |
| tint_tmax_combinefn | state1, state2 |
| tint_tmax_transfn | state, temp |
| tint_tmin_combinefn | state1, state2 |
| tint_tmin_transfn | state, temp |
| tint_to_tbigint | temp |
| tint_to_tfloat | temp |
| tint_tsum_combinefn | state1, state2 |
| tint_tsum_transfn | state, temp |
| tint_value_at_timestamptz | temp, value |
| tint_value_bins | temp, count |
| tint_value_boxes | temp, count |
| tint_value_n | temp, result |
| tint_value_split | temp, bins, count |
| tint_value_time_boxes | temp, duration, count |
| tint_value_time_split | temp, duration, value_bins, time_bins, count |
| tint_values | temp, count |
| tint_wmax_transfn | state, temp, interv |
| tint_wmin_transfn | state, temp, interv |
| tint_wsum_transfn | state, temp, interv |
| tintbox_expand | box |
| tintbox_shift_scale | box |
| tintbox_time_tiles | box, duration, count |
| tintbox_value_tiles | box, count |
| tintbox_value_time_tiles | box, duration, count |
| tintersects_cbuffer_tcbuffer | cb, temp |
| tintersects_geo_tcbuffer | gs, temp |
| tintersects_geo_tgeo | gs, temp |
| tintersects_tcbuffer_cbuffer | temp, cb |
| tintersects_tcbuffer_geo | temp, gs |
| tintersects_tcbuffer_tcbuffer | temp1, temp2 |
| tintersects_tgeo_geo | temp, gs |
| tintersects_tgeo_tgeo | temp1, temp2 |
| tintersects_tgeoarr_tgeoarr | arr1, arr2, count, periods |
| tintinst_from_mfjson | mfjson |
| tintinst_in | str |
| tintseq_from_base_tstzset | s |
| tintseq_from_base_tstzspan | s |
| tintseq_from_mfjson | mfjson |
| tintseq_in | str |
| tintseqset_from_base_tstzspanset | ss |
| tintseqset_from_mfjson | mfjson |
| tintseqset_in | str |
| tjson_array_element | temp |
| tjson_array_length | temp |
| tjson_extract_path | temp, path_elems |
| tjson_object_field | temp, key |
| tjson_strip_nulls | temp |
| tjsonb_array_element | temp |
| tjsonb_array_length | temp |
| tjsonb_at_value | temp, jsb |
| tjsonb_delete | temp, key |
| tjsonb_delete_array | temp, keys |
| tjsonb_delete_index | temp |
| tjsonb_delete_path | temp, path_elems |
| tjsonb_end_value | temp |
| tjsonb_exists | temp, key |
| tjsonb_exists_all | temp, keys |
| tjsonb_exists_any | temp, keys |
| tjsonb_exists_array | temp, keys |
| tjsonb_extract_path | temp, path_elems |
| tjsonb_from_base_temp | jsonb, temp |
| tjsonb_from_mfjson | str |
| tjsonb_in | str |
| tjsonb_insert | temp, keys, newjb |
| tjsonb_minus_value | temp, jsb |
| tjsonb_object_field | temp, key |
| tjsonb_out | temp |
| tjsonb_path_exists | temp, jp |
| tjsonb_path_match | temp, jp |
| tjsonb_path_query_array | temp, jp |
| tjsonb_path_query_first | temp, jp |
| tjsonb_pretty | temp |
| tjsonb_set | temp, keys, newjb, handle_null |
| tjsonb_start_value | temp |
| tjsonb_strip_nulls | temp |
| tjsonb_to_tbool | temp, key |
| tjsonb_to_tfloat | temp, key |
| tjsonb_to_tint | temp, key |
| tjsonb_to_ttext | temp |
| tjsonb_to_ttext_key | temp, key |
| tjsonb_value_at_timestamptz | temp, value |
| tjsonb_value_n | temp, result |
| tjsonb_values | temp, count |
| tjsonbinst_from_mfjson | mfjson |
| tjsonbinst_in | str |
| tjsonbinst_make | jsonb |
| tjsonbseq_from_base_tstzset | jsonb, s |
| tjsonbseq_from_base_tstzspan | jsonb, sp |
| tjsonbseq_from_mfjson | mfjson |
| tjsonbseq_in | str |
| tjsonbseqset_from_base_tstzspanset | jsonb, ss |
| tjsonbseqset_from_mfjson | mfjson |
| tjsonbseqset_in | str |
| tle_base_temporal | temp |
| tle_bigint_tbigint | temp |
| tle_float_tfloat | temp |
| tle_int_tint | temp |
| tle_tbigint_bigint | temp |
| tle_temporal_base | temp |
| tle_temporal_temporal | temp1, temp2 |
| tle_text_ttext | txt, temp |
| tle_tfloat_float | temp |
| tle_tint_int | temp |
| tle_ttext_text | temp, txt |
| tlt_base_temporal | temp |
| tlt_bigint_tbigint | temp |
| tlt_float_tfloat | temp |
| tlt_int_tint | temp |
| tlt_tbigint_bigint | temp |
| tlt_temporal_base | temp |
| tlt_temporal_temporal | temp1, temp2 |
| tlt_text_ttext | txt, temp |
| tlt_tfloat_float | temp |
| tlt_tint_int | temp |
| tlt_ttext_text | temp, txt |
| tne_base_temporal | temp |
| tne_bigint_tbigint | temp |
| tne_bool_tbool | temp |
| tne_cbuffer_tcbuffer | cb, temp |
| tne_float_tfloat | temp |
| tne_geo_tgeo | gs, temp |
| tne_geo_trgeometry | gs, temp |
| tne_h3index_th3index | temp |
| tne_int_tint | temp |
| tne_jsonb_tjsonb | jb, temp |
| tne_pcpatch_tpcpatch | pa, temp |
| tne_pcpoint_tpcpoint | pt, temp |
| tne_pose_tpose | pose, temp |
| tne_posechain_tposechain | posechain, temp |
| tne_quadbin_tquadbin | temp |
| tne_s2cell_ts2cell | temp |
| tne_tbigint_bigint | temp |
| tne_tbool_bool | temp |
| tne_tcbuffer_cbuffer | temp, cb |
| tne_temporal_base | temp |
| tne_temporal_temporal | temp1, temp2 |
| tne_text_ttext | txt, temp |
| tne_tfloat_float | temp |
| tne_tgeo_geo | temp, gs |
| tne_th3index_h3index | temp |
| tne_th3index_th3index | temp1, temp2 |
| tne_tint_int | temp |
| tne_tjsonb_jsonb | temp, jb |
| tne_tnpoint_npoint | temp, np |
| tne_tpcpatch_pcpatch | temp, pa |
| tne_tpcpoint_pcpoint | temp, pt |
| tne_tpose_pose | temp, pose |
| tne_tposechain_posechain | temp, posechain |
| tne_tquadbin_quadbin | temp |
| tne_tquadbin_tquadbin | temp1, temp2 |
| tne_trgeometry_geo | temp, gs |
| tne_ts2cell_s2cell | temp |
| tne_ts2cell_ts2cell | temp1, temp2 |
| tne_ttext_text | temp, txt |
| tnot_tbool | temp |
| tnpoint_at_geom | temp, gs |
| tnpoint_at_npoint | temp, np |
| tnpoint_at_npointset | temp, s |
| tnpoint_at_stbox | temp, box |
| tnpoint_cumulative_length | temp |
| tnpoint_end_value | temp |
| tnpoint_from_base_temp | np, temp |
| tnpoint_from_mfjson | mfjson |
| tnpoint_in | str |
| tnpoint_length | temp |
| tnpoint_minus_geom | temp, gs |
| tnpoint_minus_npoint | temp, np |
| tnpoint_minus_npointset | temp, s |
| tnpoint_minus_stbox | temp, box |
| tnpoint_out | temp |
| tnpoint_positions | temp, count |
| tnpoint_route | temp |
| tnpoint_routes | temp |
| tnpoint_speed | temp |
| tnpoint_start_value | temp |
| tnpoint_tcentroid_transfn | temp |
| tnpoint_to_tgeompoint | temp |
| tnpoint_trajectory | temp |
| tnpoint_twcentroid | temp |
| tnpoint_value_at_timestamptz | temp, value |
| tnpoint_value_n | temp, result |
| tnpoint_values | temp, count |
| tnpointinst_make | np |
| tnpointseq_from_base_tstzset | np, s |
| tnpointseq_from_base_tstzspan | np, s |
| tnpointseqset_from_base_tstzspanset | np, ss |
| tnumber_abs | temp |
| tnumber_angular_difference | temp |
| tnumber_at_span | temp, span |
| tnumber_at_spanset | temp, ss |
| tnumber_at_tbox | temp, box |
| tnumber_avg_value | temp |
| tnumber_delta_value | temp |
| tnumber_extent_transfn | box |
| tnumber_integral | temp |
| tnumber_minus_span | temp, span |
| tnumber_minus_spanset | temp, ss |
| tnumber_minus_tbox | temp, box |
| tnumber_restrict_span | temp, span |
| tnumber_restrict_spanset | temp, ss |
| tnumber_set_span | temp, s |
| tnumber_set_tbox | temp, box |
| tnumber_shift_scale_value | temp |
| tnumber_split_each_n_tboxes | temp, count |
| tnumber_split_n_tboxes | temp, count |
| tnumber_tavg_combinefn | state1, state2 |
| tnumber_tavg_transfn | state, temp |
| tnumber_tboxes | temp, count |
| tnumber_to_span | temp |
| tnumber_to_tbox | temp |
| tnumber_trend | temp |
| tnumber_twavg | temp |
| tnumber_value_bins | temp, count |
| tnumber_value_split | temp, bins, count |
| tnumber_value_time_boxes | temp, count |
| tnumber_value_time_split | temp, duration, value_bins, time_bins, count |
| tnumber_valuespans | temp |
| tnumber_wavg_transfn | state, temp, interv |
| tnumberinst_abs | inst |
| tnumberinst_distance | inst1, inst2 |
| tnumberinst_restrict_span | inst, span |
| tnumberinst_restrict_spanset | inst, ss |
| tnumberinst_set_tbox | inst, box |
| tnumberinst_shift_value | inst |
| tnumberinst_valuespans | inst |
| tnumberseq_abs | seq |
| tnumberseq_angular_difference | seq |
| tnumberseq_avg_val | seq |
| tnumberseq_delta_value | seq |
| tnumberseq_integral | seq |
| tnumberseq_set_tbox | seq, box |
| tnumberseq_shift_scale_value | seq |
| tnumberseq_twavg | seq |
| tnumberseq_valuespans | seq |
| tnumberseqset_abs | ss |
| tnumberseqset_angular_difference | ss |
| tnumberseqset_avg_val | ss |
| tnumberseqset_delta_value | ss |
| tnumberseqset_integral | ss |
| tnumberseqset_restrict_span | ss, span |
| tnumberseqset_restrict_spanset | ss, spanset |
| tnumberseqset_set_tbox | ss, box |
| tnumberseqset_shift_scale_value | ss |
| tnumberseqset_twavg | ss |
| tnumberseqset_valuespans | ss |
| tor_bool_tbool | temp |
| tor_tbool_bool | temp |
| tor_tbool_tbool | temp1, temp2 |
| touches_cbuffer_cbuffer | cb1, cb2 |
| tpcbox_cmp | box1, box2 |
| tpcbox_copy | box |
| tpcbox_eq | box1, box2 |
| tpcbox_ge | box1, box2 |
| tpcbox_geodetic | box |
| tpcbox_gt | box1, box2 |
| tpcbox_hast | box |
| tpcbox_hasx | box |
| tpcbox_hasz | box |
| tpcbox_in | str |
| tpcbox_le | box1, box2 |
| tpcbox_lt | box1, box2 |
| tpcbox_ne | box1, box2 |
| tpcbox_out | box |
| tpcbox_pcid | box |
| tpcbox_round | box |
| tpcbox_set_srid | box |
| tpcbox_srid | box |
| tpcbox_tmax | box, result |
| tpcbox_tmax_inc | box, result |
| tpcbox_tmin | box, result |
| tpcbox_tmin_inc | box, result |
| tpcbox_to_stbox | box |
| tpcbox_xmax | box, result |
| tpcbox_xmin | box, result |
| tpcbox_ymax | box, result |
| tpcbox_ymin | box, result |
| tpcbox_zmax | box, result |
| tpcbox_zmin | box, result |
| tpcpatch_at_value | temp, pa |
| tpcpatch_end_value | temp |
| tpcpatch_from_base_temp | pa, temp |
| tpcpatch_minus_value | temp, pa |
| tpcpatch_start_value | temp |
| tpcpatch_to_tgeometry | temp |
| tpcpatch_value_at_timestamptz | temp, value |
| tpcpatch_value_n | temp, result |
| tpcpatch_values | temp, count |
| tpcpatchinst_make | pa |
| tpcpatchseq_from_base_tstzset | pa, s |
| tpcpatchseq_from_base_tstzspan | pa, sp |
| tpcpatchseqset_from_base_tstzspanset | pa, ss |
| tpcpoint_at_value | temp, pt |
| tpcpoint_end_value | temp |
| tpcpoint_from_base_temp | pt, temp |
| tpcpoint_minus_value | temp, pt |
| tpcpoint_start_value | temp |
| tpcpoint_value_at_timestamptz | temp, value |
| tpcpoint_value_n | temp, result |
| tpcpoint_values | temp, count |
| tpcpointinst_make | pt |
| tpcpointseq_from_base_tstzset | pt, s |
| tpcpointseq_from_base_tstzspan | pt, sp |
| tpcpointseqset_from_base_tstzspanset | pt, ss |
| tpoint_angular_difference | temp |
| tpoint_as_mvtgeom | temp, bounds |
| tpoint_at_elevation | temp, s |
| tpoint_at_geom | temp, gs |
| tpoint_at_value | temp, gs |
| tpoint_azimuth | temp |
| tpoint_cumulative_length | temp |
| tpoint_direction | temp, result |
| tpoint_from_base_temp | gs, temp |
| tpoint_get_coord | temp |
| tpoint_get_x | temp |
| tpoint_get_y | temp |
| tpoint_get_z | temp |
| tpoint_is_simple | temp |
| tpoint_length | temp |
| tpoint_linear_distance_geom | temp, gs |
| tpoint_linear_dwithin_geom | temp, gs |
| tpoint_linear_dwithin_geom_ctx | temp, ctx |
| tpoint_linear_inter_geom | temp, gs |
| tpoint_linear_inter_geom_ctx | temp, ctx |
| tpoint_linear_restrict_geom | temp, gs |
| tpoint_make_simple | temp, count |
| tpoint_minus_elevation | temp, s |
| tpoint_minus_geom | temp, gs |
| tpoint_minus_value | temp, gs |
| tpoint_speed | temp |
| tpoint_tcentroid_transfn | temp |
| tpoint_tfloat_to_geomeas | tpoint, measure, result |
| tpoint_trajectory | temp |
| tpoint_twcentroid | temp |
| tpointcloud_to_tgeompoint | temp |
| tpointinst_make | gs |
| tpointseq_azimuth | seq |
| tpointseq_cumulative_length | seq |
| tpointseq_from_base_tstzset | gs, s |
| tpointseq_from_base_tstzspan | gs, s |
| tpointseq_is_simple | seq |
| tpointseq_length | seq |
| tpointseq_linear_trajectory | seq |
| tpointseq_make_coords | xcoords, ycoords, zcoords, times |
| tpointseq_make_simple | seq, count |
| tpointseq_twcentroid | seq |
| tpointseqset_azimuth | ss |
| tpointseqset_cumulative_length | ss |
| tpointseqset_from_base_tstzspanset | gs, ss |
| tpointseqset_is_simple | ss |
| tpointseqset_length | ss |
| tpointseqset_make_simple | ss, count |
| tpointseqset_twcentroid | ss |
| tpose_angular_speed | temp |
| tpose_apply_geo | temp, body |
| tpose_as_geopose | temp |
| tpose_as_geopose_stream | temp |
| tpose_as_geopose_stream_element | temp, inst |
| tpose_as_geopose_stream_header | temp |
| tpose_at_elevation | temp, s |
| tpose_at_geom | temp, gs |
| tpose_at_pose | temp, pose |
| tpose_at_stbox | temp, box |
| tpose_compose_pose | body, frame |
| tpose_compose_tpose | body, frame |
| tpose_end_value | temp |
| tpose_from_base_temp | pose, temp |
| tpose_from_geopose | json |
| tpose_from_mfjson | str |
| tpose_in | str |
| tpose_inverse | temp |
| tpose_make | tpoint, ttheta |
| tpose_minus_elevation | temp, s |
| tpose_minus_geom | temp, gs |
| tpose_minus_pose | temp, pose |
| tpose_minus_stbox | temp, box |
| tpose_pitch | temp |
| tpose_points | temp |
| tpose_roll | temp |
| tpose_speed | temp |
| tpose_start_value | temp |
| tpose_to_tpoint | temp |
| tpose_trajectory | temp |
| tpose_value_at_timestamptz | temp, result |
| tpose_value_n | temp, result |
| tpose_values | temp, count |
| tpose_yaw | temp |
| tposechain_as_geopose | temp |
| tposechain_from_base_temp | pc, temp |
| tposechain_from_geopose | json |
| tposechain_from_mfjson | mfjson |
| tposechain_in | str |
| tposechain_num_poses | temp |
| tposechain_to_tpose | temp |
| tposechainarr_as_geopose | temparr |
| tposeinst_make | pose |
| tposeseq_from_base_tstzset | pose, s |
| tposeseq_from_base_tstzspan | pose, s |
| tposeseqset_from_base_tstzspanset | pose, ss |
| tquadbin_cell_to_quadkey | temp |
| tquadbin_end_value | temp |
| tquadbin_in | str |
| tquadbin_start_value | temp |
| tquadbin_to_tbigint | temp |
| tquadbin_value_at_timestamptz | temp, result |
| tquadbin_value_n | temp, result |
| tquadbin_values | temp, count |
| tquadbininst_in | str |
| tquadbinseq_in | str |
| tquadbinseq_make | values, times |
| tquadbinseqset_in | str |
| tquadbinseqset_make | sequences |
| trajectory_quadbins | traj, count |
| trgeometry_after_timestamptz | temp |
| trgeometry_angular_speed | temp |
| trgeometry_append_tinstant | temp, inst |
| trgeometry_append_tsequence | temp, seq |
| trgeometry_as_ewkt | temp |
| trgeometry_as_text | temp |
| trgeometry_as_tinstant | temp |
| trgeometry_as_tsequence | temp |
| trgeometry_as_tsequenceset | temp, interp_str |
| trgeometry_at_elevation | temp, s |
| trgeometry_at_geom | temp, gs |
| trgeometry_at_stbox | temp, box |
| trgeometry_at_timestamptz | temp |
| trgeometry_at_tstzset | temp, s |
| trgeometry_at_tstzspan | temp, s |
| trgeometry_at_tstzspanset | temp, ss |
| trgeometry_at_value | temp, pose |
| trgeometry_at_values | temp, s |
| trgeometry_before_timestamptz | temp |
| trgeometry_body_point_trajectory | temp, gs |
| trgeometry_centroid | temp |
| trgeometry_convex_hull | temp |
| trgeometry_cumulative_length | temp |
| trgeometry_delete_timestamptz | temp |
| trgeometry_delete_tstzset | temp, s |
| trgeometry_delete_tstzspan | temp, s |
| trgeometry_delete_tstzspanset | temp, ss |
| trgeometry_dyntimewarp_distance | temp1, temp2 |
| trgeometry_dyntimewarp_path | temp1, temp2, count |
| trgeometry_end_instant | temp |
| trgeometry_end_sequence | temp |
| trgeometry_end_value | temp |
| trgeometry_frechet_distance | temp1, temp2 |
| trgeometry_frechet_path | temp1, temp2, count |
| trgeometry_from_mfjson | mfjson |
| trgeometry_geom | temp |
| trgeometry_hausdorff_distance | temp1, temp2 |
| trgeometry_in | str |
| trgeometry_instant_n | temp |
| trgeometry_instants | temp, count |
| trgeometry_length | temp |
| trgeometry_merge | temp1, temp2 |
| trgeometry_merge_array | temparr |
| trgeometry_minus_elevation | temp, s |
| trgeometry_minus_geom | temp, gs |
| trgeometry_minus_stbox | temp, box |
| trgeometry_minus_timestamptz | temp |
| trgeometry_minus_tstzset | temp, s |
| trgeometry_minus_tstzspan | temp, s |
| trgeometry_minus_tstzspanset | temp, ss |
| trgeometry_minus_value | temp, pose |
| trgeometry_minus_values | temp, s |
| trgeometry_out | temp |
| trgeometry_pitch | temp |
| trgeometry_points | temp |
| trgeometry_restrict_timestamptz | temp |
| trgeometry_restrict_tstzset | temp, s |
| trgeometry_restrict_tstzspan | temp, s |
| trgeometry_restrict_tstzspanset | temp, ss |
| trgeometry_restrict_values | temp, s |
| trgeometry_roll | temp |
| trgeometry_round | temp |
| trgeometry_segments | temp, count |
| trgeometry_sequence_n | temp |
| trgeometry_sequences | temp, count |
| trgeometry_set_interp | temp |
| trgeometry_space_boxes | temp, sorigin, count |
| trgeometry_space_time_boxes | temp, duration, sorigin, count |
| trgeometry_speed | temp |
| trgeometry_split_each_n_stboxes | temp, count |
| trgeometry_split_n_stboxes | temp, count |
| trgeometry_start_instant | temp |
| trgeometry_start_sequence | temp |
| trgeometry_start_value | temp |
| trgeometry_stboxes | temp, count |
| trgeometry_to_tgeometry | temp |
| trgeometry_to_tgeompoint | temp |
| trgeometry_to_tpose | temp |
| trgeometry_traversed_area | temp |
| trgeometry_twcentroid | temp |
| trgeometry_value_n | temp, result |
| trgeometry_yaw | temp |
| trgeometryinst_make | geom, pose |
| trgeometryseq_make | geom, instants |
| trgeometryseqset_make | geom, sequences |
| trgeometryseqset_make_gaps | geom, instants |
| ts2cell_cell_to_token | temp |
| ts2cell_end_value | temp |
| ts2cell_in | str |
| ts2cell_start_value | temp |
| ts2cell_to_tbigint | temp |
| ts2cell_value_at_timestamptz | temp, result |
| ts2cell_value_n | temp, result |
| ts2cell_values | temp, count |
| ts2cellinst_in | str |
| ts2cellseq_in | str |
| ts2cellseq_make | values, times |
| ts2cellseqset_in | str |
| ts2cellseqset_make | sequences |
| tseqsetarr_to_tseqset | seqsets |
| tsequence_append_tinstant | seq, inst |
| tsequence_append_tsequence | seq1, seq2 |
| tsequence_as_tinstant | seq |
| tsequence_as_tsequenceset | seq |
| tsequence_at_timestamptz | seq |
| tsequence_cmp | seq1, seq2 |
| tsequence_compact | seq |
| tsequence_copy | seq |
| tsequence_delete_timestamptz | seq |
| tsequence_delete_tstzset | seq, s |
| tsequence_delete_tstzspan | seq, s |
| tsequence_delete_tstzspanset | seq, ss |
| tsequence_duration | seq |
| tsequence_end_timestamptz | seq |
| tsequence_eq | seq1, seq2 |
| tsequence_expand_bbox | seq, inst |
| tsequence_from_base_temp | seq |
| tsequence_from_base_tstzset | s |
| tsequence_from_base_tstzspan | s |
| tsequence_from_mfjson | mfjson |
| tsequence_hash | seq |
| tsequence_hash_extended | seq |
| tsequence_in | str |
| tsequence_insert | seq1, seq2 |
| tsequence_insts_p | seq, count |
| tsequence_make | instants |
| tsequence_make_exp | instants |
| tsequence_make_free | instants |
| tsequence_max_inst_p | seq |
| tsequence_max_val | seq |
| tsequence_merge | seq1, seq2 |
| tsequence_merge_array | sequences |
| tsequence_min_inst_p | seq |
| tsequence_min_val | seq |
| tsequence_out | seq |
| tsequence_restart | seq |
| tsequence_restrict_tstzspan | seq, s |
| tsequence_restrict_tstzspanset | seq, ss |
| tsequence_segments | seq, count |
| tsequence_seqs | seq, count |
| tsequence_set_bbox | seq, box |
| tsequence_set_interp | seq |
| tsequence_set_tstzspan | seq, s |
| tsequence_shift_scale_time | seq, shift, duration |
| tsequence_start_timestamptz | seq |
| tsequence_subseq | seq |
| tsequence_time | seq |
| tsequence_timestamps | seq, count |
| tsequence_to_tsequenceset_free | seq |
| tsequence_to_tsequenceset_interp | seq |
| tsequence_value_at_timestamptz | seq, result |
| tsequence_values_p | seq, count |
| tsequenceset_after_timestamptz | ss |
| tsequenceset_append_tinstant | ss, inst |
| tsequenceset_append_tsequence | ss, seq |
| tsequenceset_as_tinstant | ss |
| tsequenceset_as_tsequence | ss |
| tsequenceset_before_timestamptz | ss |
| tsequenceset_cmp | ss1, ss2 |
| tsequenceset_compact | ss |
| tsequenceset_copy | ss |
| tsequenceset_delete_timestamptz | ss |
| tsequenceset_delete_tstzset | ss, s |
| tsequenceset_delete_tstzspan | ss, s |
| tsequenceset_delete_tstzspanset | ss, ps |
| tsequenceset_duration | ss |
| tsequenceset_end_timestamptz | ss |
| tsequenceset_eq | ss1, ss2 |
| tsequenceset_expand_bbox | ss, seq |
| tsequenceset_from_base_temp | ss |
| tsequenceset_from_base_tstzspanset | ss |
| tsequenceset_from_mfjson | mfjson |
| tsequenceset_hash | ss |
| tsequenceset_hash_extended | ss |
| tsequenceset_in | str |
| tsequenceset_insert | ss1, ss2 |
| tsequenceset_inst_n | ss |
| tsequenceset_insts_p | ss, count |
| tsequenceset_make | sequences |
| tsequenceset_make_exp | sequences |
| tsequenceset_make_free | sequences |
| tsequenceset_make_gaps | instants |
| tsequenceset_max_inst_p | ss |
| tsequenceset_max_val | ss |
| tsequenceset_merge | ss1, ss2 |
| tsequenceset_merge_array | seqsets |
| tsequenceset_min_inst_p | ss |
| tsequenceset_min_val | ss |
| tsequenceset_num_instants | ss |
| tsequenceset_num_timestamps | ss |
| tsequenceset_out | ss |
| tsequenceset_restart | ss |
| tsequenceset_restrict_minmax | ss |
| tsequenceset_restrict_timestamptz | ss |
| tsequenceset_restrict_tstzset | ss, s |
| tsequenceset_restrict_tstzspan | ss, s |
| tsequenceset_restrict_tstzspanset | ss, ps |
| tsequenceset_restrict_value | ss |
| tsequenceset_restrict_values | ss, s |
| tsequenceset_segments | ss, count |
| tsequenceset_sequences_p | ss |
| tsequenceset_set_bbox | ss, box |
| tsequenceset_set_interp | ss |
| tsequenceset_set_tstzspan | ss, s |
| tsequenceset_shift_scale_time | ss, start, duration |
| tsequenceset_start_timestamptz | ss |
| tsequenceset_time | ss |
| tsequenceset_timestamps | ss, count |
| tsequenceset_timestamptz_n | ss, result |
| tsequenceset_to_discrete | ss |
| tsequenceset_to_linear | ss |
| tsequenceset_to_step | ss |
| tsequenceset_value_at_timestamptz | ss, result |
| tsequenceset_value_n | ss, result |
| tsequenceset_value_n_p | ss, result |
| tsequenceset_values_p | ss, count |
| tspatial_as_ewkt | temp |
| tspatial_as_text | temp |
| tspatial_extent_transfn | box |
| tspatial_out | temp |
| tspatial_set_srid | temp |
| tspatial_set_stbox | temp, result |
| tspatial_srid | temp |
| tspatial_to_stbox | temp |
| tspatial_transform | temp |
| tspatial_transform_pipeline | temp, pipelinestr |
| tspatialinst_set_srid | inst |
| tspatialinst_srid | inst |
| tspatialseq_set_srid | seq |
| tspatialseq_set_stbox | seq, box |
| tspatialseqset_set_srid | ss |
| tspatialseqset_set_stbox | ss, box |
| tstzset_end_value | s |
| tstzset_in | str |
| tstzset_make | values |
| tstzset_out | set |
| tstzset_set_stbox | s, result |
| tstzset_set_tbox | s, box |
| tstzset_shift_scale | s |
| tstzset_start_value | s |
| tstzset_tcount_transfn | s |
| tstzset_to_dateset | s |
| tstzset_to_stbox | s |
| tstzset_tprecision | s, duration |
| tstzset_value_n | s, result |
| tstzset_values | s, count |
| tstzspan_bins | s, duration, count |
| tstzspan_duration | s |
| tstzspan_expand | s, interv |
| tstzspan_in | str |
| tstzspan_lower | s |
| tstzspan_out | s |
| tstzspan_set_datespan | s1, s2 |
| tstzspan_set_stbox | s, result |
| tstzspan_set_tbox | s, box |
| tstzspan_shift_scale | s |
| tstzspan_tcount_transfn | s |
| tstzspan_to_datespan | s |
| tstzspan_to_stbox | s |
| tstzspan_tprecision | s, duration |
| tstzspan_upper | s |
| tstzspanset_bins | ss, duration, count |
| tstzspanset_duration | ss |
| tstzspanset_end_timestamptz | ss |
| tstzspanset_in | str |
| tstzspanset_lower | ss |
| tstzspanset_num_timestamps | ss |
| tstzspanset_out | ss |
| tstzspanset_set_stbox | s, result |
| tstzspanset_shift_scale | ss |
| tstzspanset_start_timestamptz | ss |
| tstzspanset_tcount_transfn | ss |
| tstzspanset_timestamps | ss |
| tstzspanset_timestamptz_n | ss, result |
| tstzspanset_to_datespanset | ss |
| tstzspanset_to_stbox | ss |
| tstzspanset_tprecision | ss, duration |
| tstzspanset_upper | ss |
| ttext_at_value | temp, txt |
| ttext_end_value | temp |
| ttext_from_base_temp | txt, temp |
| ttext_from_mfjson | str |
| ttext_in | str |
| ttext_initcap | temp |
| ttext_lower | temp |
| ttext_max_value | temp |
| ttext_min_value | temp |
| ttext_minus_value | temp, txt |
| ttext_out | temp |
| ttext_start_value | temp |
| ttext_tmax_combinefn | state1, state2 |
| ttext_tmax_transfn | state, temp |
| ttext_tmin_combinefn | state1, state2 |
| ttext_tmin_transfn | state, temp |
| ttext_to_tjsonb | temp |
| ttext_upper | temp |
| ttext_value_at_timestamptz | temp, value |
| ttext_value_n | temp, result |
| ttext_values | temp, count |
| ttextinst_from_mfjson | mfjson |
| ttextinst_in | str |
| ttextinst_make | txt |
| ttextseq_from_base_tstzset | txt, s |
| ttextseq_from_base_tstzspan | txt, s |
| ttextseq_from_mfjson | mfjson |
| ttextseq_in | str |
| ttextseqset_from_base_tstzspanset | txt, ss |
| ttextseqset_from_mfjson | mfjson |
| ttextseqset_in | str |
| ttouches_cbuffer_tcbuffer | cb, temp |
| ttouches_geo_tcbuffer | gs, temp |
| ttouches_geo_tgeo | gs, temp |
| ttouches_tcbuffer_cbuffer | temp, cb |
| ttouches_tcbuffer_geo | temp, gs |
| ttouches_tcbuffer_tcbuffer | temp1, temp2 |
| ttouches_tgeo_geo | temp, gs |
| ttouches_tgeo_tgeo | temp1, temp2 |
| ttouches_tgeoarr_tgeoarr | arr1, arr2, count, periods |
| unicode_assigned | txt |
| unicode_is_normalized | txt, fmt |
| unicode_normalize_func | txt, fmt |
| union_bigint_set | s |
| union_bigint_span | s |
| union_bigint_spanset | ss |
| union_cbuffer_set | cb, s |
| union_date_set | s |
| union_date_span | s |
| union_date_spanset | ss |
| union_float_set | s |
| union_float_span | s |
| union_float_spanset | ss |
| union_geo_set | gs, s |
| union_int_set | s |
| union_int_span | s |
| union_int_spanset | ss |
| union_jsonb_set | jb, s |
| union_npoint_set | np, s |
| union_pcpatch_set | pa, s |
| union_pcpoint_set | pt, s |
| union_pose_set | pose, s |
| union_posechain_set | pc, s |
| union_set_bigint | s |
| union_set_cbuffer | s, cb |
| union_set_date | s |
| union_set_float | s |
| union_set_geo | s, gs |
| union_set_int | s |
| union_set_jsonb | s, jb |
| union_set_npoint | s, np |
| union_set_pcpatch | s, pa |
| union_set_pcpoint | s, pt |
| union_set_pose | s, pose |
| union_set_posechain | s, pc |
| union_set_set | s1, s2 |
| union_set_text | s, txt |
| union_set_timestamptz | s |
| union_set_value | s |
| union_span_bigint | s |
| union_span_date | s |
| union_span_float | s |
| union_span_int | s |
| union_span_span | s1, s2 |
| union_span_spanset | s, ss |
| union_span_timestamptz | s |
| union_span_value | s |
| union_spanset_bigint | ss |
| union_spanset_date | ss |
| union_spanset_float | ss |
| union_spanset_int | ss |
| union_spanset_span | ss, s |
| union_spanset_spanset | ss1, ss2 |
| union_spanset_timestamptz | ss |
| union_spanset_value | ss |
| union_stbox_stbox | box1, box2 |
| union_tbox_tbox | box1, box2 |
| union_text_set | txt, s |
| union_timestamptz_set | s |
| union_timestamptz_span | s |
| union_timestamptz_spanset | ss |
| union_tpcbox_tpcbox | box1, box2 |
| union_value_set | s |
| union_value_span | s |
| union_value_spanset | ss |
| unistr | txt |
| value_set_span | s |
| value_union_transfn | state |
| wkb_variant_from_endian | endian |

### unreadable return — 4

A pointer answer whose pointed-to type no emitted function accepts. The caller receives an address and the catalog names nothing this binding reaches that renders it, operates on it or takes it back.

| function | api | pointed-to type |
| --- | --- | --- |
| geopose_frame | public | GeoPoseFrame |
| geopose_frames | public | GeoPoseFrame |
| geos_get_context | internal | struct GEOSContextHandle_HS |
| meos_proj_get_context | internal | struct pj_ctx |

### unmapped C type — 0

A type crossing the boundary by value that the C# mapping does not name. It reaches the surface as an opaque pointer, which reads an address where the ABI passes a value.

None in this run.

### struct field width — 2

A struct the emitted surface names, holding a field whose type the catalog gives no scalar width and no layout of its own, so the struct cannot be laid out and stays an opaque pointer. A struct no emitted function names is left out: this binding lays out no such struct, so its width is a contract nothing here needs.

| struct | field | type |
| --- | --- | --- |
| GBOX | flags | lwflags_t |
| LWGEOM | flags | lwflags_t |

### array element type — 1

A function the catalog states answers an array without stating what the elements are. Emitted as a stub: a wrapper would walk the array at a stride the catalog never states.

| function | return | what is missing |
| --- | --- | --- |
| bbox_temporal_split_boxes | void * | the catalog states this answers an array and states no element type for it — `void *` names neither the type to read an element as nor the width to step by |

### array return length — 0

An `arrayReturn` whose length the catalog states in a way this generator reads no length out of.

None in this run.

### output array length — 0

An `outputArrays` parameter with no length source, so the count of what the callee wrote is unstated.

None in this run.

### value text I/O — 5

A struct the binding carries as a value and the catalog names no complete text reader and writer for, so the value states itself in no form a caller can read or write.

| struct | what is missing |
| --- | --- |
| AFFINE | serialization names in=None out=None |
| Match | serialization names in=None out=None |
| MvtGeom | serialization names in=None out=None |
| SpaceSplit | serialization names in=None out=None |
| SpaceTimeSplit | serialization names in=None out=None |

<!-- gap-ledger:end flat surface -->

<!-- gap-ledger:begin object layer -->

## The object layer — `tools/objectgen.py`

### function absent from the catalog — 0

The model assigns a method to a function the catalog's own function list does not carry, so there is nothing to call.

None in this run.

### no emitted wrapper — 0

The flat surface emits no wrapper for the function, so the layer has no signature to build a method on. The reason sits in the flat surface's own section.

None in this run.

### return needs a class — 2

The function answers a type no class stands for and no scalar, value struct or array rule reads, so there is nothing to hand back.

| class | member | what is missing |
| --- | --- | --- |
| Jsonb | toNumeric | return Numeric needs wrapping |
| STBox | toGbox | return GBOX * needs wrapping |

### argument needs a class — 4

The function takes a type no class stands for and no marshalling rule reads, so there is nothing for a caller to pass.

| class | member | what is missing |
| --- | --- | --- |
| Jsonb | each | argument values of type Jsonb ** needs marshalling |
| Jsonb | eachText | argument values of type text ** needs marshalling |
| Pcschema | fromDims | argument dims of type PCDimensionSpec * needs marshalling |
| Pcschema | registerDims | argument dims of type PCDimensionSpec * needs marshalling |

<!-- gap-ledger:end object layer -->
