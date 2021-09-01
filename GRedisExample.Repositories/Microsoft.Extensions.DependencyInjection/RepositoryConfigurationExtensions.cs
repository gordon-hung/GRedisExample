﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GRedisExample.Repositories;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class RepositoryConfigurationExtensions
    {
        /// <summary>
        /// Adds the repositories.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <returns></returns>
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services.AddTransient<IRedisStringRepository, RedisStringRepository>();
        }
    }
}
