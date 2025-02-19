﻿using Microsoft.EntityFrameworkCore.Query;
using Zack.EFCore.Batch.MySQL.Pomelo.Internal;

namespace Microsoft.EntityFrameworkCore
{
    public static class DbContextOptionsBuilderExtension_MySQLPomelo
    {
        public static DbContextOptionsBuilder UseBatchEF_MySQLPomelo(this DbContextOptionsBuilder optBuilder)
        {
            optBuilder.ReplaceService<IQuerySqlGeneratorFactory, ZackQuerySqlGeneratorFactory_MySQLPomelo>();
            return optBuilder;
        }
    }
}
