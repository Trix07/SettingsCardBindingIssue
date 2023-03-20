// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;

using SettingsCardBindingIssue.ViewModels;

namespace SettingsCardBindingIssue;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        ViewModel = new MainWindowViewModel();
    }

    public MainWindowViewModel ViewModel { get; private set; }
}
