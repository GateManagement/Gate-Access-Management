using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Gate_Access_Management.ViewModels.Pages.Setup;

public partial class SetupHostViewModel : ViewModelBase
{
    public SetupOptionsViewModel Options { get; }
    public SetupAccessSchedulesViewModel AccessSchedules { get; } = new();
    public SetupUnitTypesViewModel UnitTypes { get; } = new();
    public SetupSettingsViewModel Settings { get; } = new();

    [ObservableProperty]
    private ViewModelBase _currentView;

    public bool ShowBackButton => CurrentView != Options;

    public SetupHostViewModel()
    {
        Options = new SetupOptionsViewModel(this);
        _currentView = Options;
    }

    public void ShowDefault()
    {
        CurrentView = Options;
    }

    partial void OnCurrentViewChanged(ViewModelBase value)
    {
        OnPropertyChanged(nameof(ShowBackButton));
    }

    [RelayCommand]
    private void ShowOptions() => CurrentView = Options;

    [RelayCommand]
    private void ShowAccessSchedules() => CurrentView = AccessSchedules;

    [RelayCommand]
    private void ShowUnitTypes() => CurrentView = UnitTypes;

    [RelayCommand]
    private void ShowSettings() => CurrentView = Settings;
}