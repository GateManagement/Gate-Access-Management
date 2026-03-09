using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Gate_Access_Management.ViewModels.Pages.Reports;

public partial class ReportHostViewModel : ViewModelBase
{
    public ReportOptionsViewModel Options { get; }
    public ReportLogsViewModel Logs { get; } = new();
    public ReportRentalsViewModel Rentals { get; } = new();
    public ReportTenantsViewModel Tenants { get; } = new();
    public ReportUnitsViewModel Units { get; } = new();

    [ObservableProperty]
    private ViewModelBase _currentView;

    public bool ShowBackButton => CurrentView != Options;

    public ReportHostViewModel()
    {
        Options = new ReportOptionsViewModel(this);
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
    private void ShowLogs() => CurrentView = Logs;

    [RelayCommand]
    private void ShowRentals() => CurrentView = Rentals;

    [RelayCommand]
    private void ShowTenants() => CurrentView = Tenants;

    [RelayCommand]
    private void ShowUnits() => CurrentView = Units;
}