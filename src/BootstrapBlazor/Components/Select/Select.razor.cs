﻿using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using System.Diagnostics.CodeAnalysis;

namespace BootstrapBlazor.Components
{
    /// <summary>
    /// Select 组件实现类
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    public sealed partial class Select<TValue>
    {
        [Inject]
        [NotNull]
        private IStringLocalizer<Select<TValue>>? Localizer { get; set; }

        /// <summary>
        /// OnInitialized 方法
        /// </summary>
        protected override void OnInitialized()
        {
            base.OnInitialized();

            PlaceHolder ??= Localizer[nameof(PlaceHolder)];
        }
    }
}
