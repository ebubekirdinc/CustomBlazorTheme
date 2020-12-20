﻿using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace CustomBlazorTheme.EntityFrameworkCore
{
    public static class CustomBlazorThemeDbContextModelCreatingExtensions
    {
        public static void ConfigureCustomBlazorTheme(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(CustomBlazorThemeConsts.DbTablePrefix + "YourEntities", CustomBlazorThemeConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}