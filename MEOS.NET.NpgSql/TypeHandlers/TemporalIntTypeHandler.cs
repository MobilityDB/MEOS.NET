using Npgsql;
using Npgsql.Internal;
using Npgsql.Internal.TypeHandling;
using Npgsql.BackendMessages;

using NpgsqlTypes;
using Npgsql.PostgresTypes;
using MEOS.NET.Types.Temporal;

namespace MEOS.NET.NpgSql.TypeHandlers
{
    public class TemporalIntTypeHandler : NpgsqlSimpleTypeHandler<TemporalInt>
    {
        public TemporalIntTypeHandler(PostgresType postgresType) : base(postgresType)
        {
            Npgsql.PostgresTypes.PostgresBaseType x;
            Npgsql.PostgresTypes.PostgresCompositeType y;
        }

        public override TemporalInt Read(NpgsqlReadBuffer buf, int len, FieldDescription? fieldDescription = null)
        {
            //var x = buf.ReadMemory(len).ToString();
            return new TemporalInt { };
        }

        public override int ValidateAndGetLength(TemporalInt value, NpgsqlParameter? parameter)
        {
            throw new NotImplementedException();
        }

        public override int ValidateObjectAndGetLength(object value, ref NpgsqlLengthCache? lengthCache, NpgsqlParameter? parameter)
        {
            throw new NotImplementedException();
        }

        public override void Write(TemporalInt value, NpgsqlWriteBuffer buf, NpgsqlParameter? parameter)
        {
            throw new NotImplementedException();
        }

        public override Task WriteObjectWithLength(object? value, NpgsqlWriteBuffer buf, NpgsqlLengthCache? lengthCache, NpgsqlParameter? parameter, bool async, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}