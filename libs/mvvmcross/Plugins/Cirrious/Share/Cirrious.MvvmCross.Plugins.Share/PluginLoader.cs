﻿// PluginLoader.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using Cirrious.CrossCore.IoC;
using Cirrious.CrossCore.Plugins;

namespace Cirrious.MvvmCross.Plugins.Share
{
    public class PluginLoader
        : IMvxPluginLoader          
    {
        public static readonly PluginLoader Instance = new PluginLoader();

        public void EnsureLoaded()
        {
            var manager = Mvx.Resolve<IMvxPluginManager>();
            manager.EnsureLoaded<PluginLoader>();
        }
    }
}