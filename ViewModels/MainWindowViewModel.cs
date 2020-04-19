﻿using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Atlassian.Jira;
using Sikor.Services;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Sikor.Model;
using Sikor.Repository;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using System.Reflection;
using Sikor.Container;

namespace Sikor.ViewModels
{
    public class MainWindowViewModel : ReactiveViewServiceProvider
    {
        protected bool loginFormVisible = true;
        public bool LoginFormVisible
        {
            get => loginFormVisible;
            set => this.RaiseAndSetIfChanged(ref loginFormVisible, value);
        }

        public string Version
        {
            get
            {
                return Assembly.GetEntryAssembly().GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
            }
        }
    }
}
