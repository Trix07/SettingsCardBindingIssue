using CommunityToolkit.Mvvm.ComponentModel;

namespace SettingsCardBindingIssue.ViewModels;

public class MainWindowViewModel : ObservableObject
{
    private string _description = string.Empty;
    public string Description
    {
        get => _description;
        set => SetProperty(ref _description, value);
    }
}
