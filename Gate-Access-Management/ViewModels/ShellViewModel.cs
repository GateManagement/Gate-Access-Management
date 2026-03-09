using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Gate_Access_Management.ViewModels.Pages;
using Gate_Access_Management.ViewModels.Pages.Units;
using Gate_Access_Management.ViewModels.Pages.Reports;
using Gate_Access_Management.ViewModels.Pages.Setup;
using Gate_Access_Management.ViewModels.Pages.Tenants;

namespace Gate_Access_Management.ViewModels;

public partial class ShellViewModel : ViewModelBase
{
    private readonly LogsViewModel _logs = new();
    private readonly TenantHostViewModel _tenants = new();
    private readonly UnitHostViewModel _units = new();
    private readonly GateViewModel _gate = new();
    private readonly ReportHostViewModel _reports = new();
    private readonly SetupHostViewModel _setup = new();
    private readonly HelpViewModel _help = new();

    [ObservableProperty] private ViewModelBase _currentPage;

    [ObservableProperty] private bool _isLogsSelected;
    [ObservableProperty] private bool _isTenantsSelected;
    [ObservableProperty] private bool _isUnitsSelected;
    [ObservableProperty] private bool _isGateSelected;
    [ObservableProperty] private bool _isReportsSelected;
    [ObservableProperty] private bool _isSetupSelected;
    [ObservableProperty] private bool _isHelpSelected;

    public ShellViewModel()
    {
        _currentPage = _logs;
        SelectOnly(nameof(IsLogsSelected));
    }

    private void SelectOnly(string name)
    {
        IsLogsSelected = false;
        IsTenantsSelected = false;
        IsUnitsSelected = false;
        IsGateSelected = false;
        IsReportsSelected = false;
        IsSetupSelected = false;
        IsHelpSelected = false;

        if (name == nameof(IsLogsSelected)) IsLogsSelected = true;
        if (name == nameof(IsTenantsSelected)) IsTenantsSelected = true;
        if (name == nameof(IsUnitsSelected)) IsUnitsSelected = true;
        if (name == nameof(IsGateSelected)) IsGateSelected = true;
        if (name == nameof(IsReportsSelected)) IsReportsSelected = true;
        if (name == nameof(IsSetupSelected)) IsSetupSelected = true;
        if (name == nameof(IsHelpSelected)) IsHelpSelected = true;
    }

    [RelayCommand]
    private void ShowLogs()
    {
        CurrentPage = _logs;
        SelectOnly(nameof(IsLogsSelected));
    }

    [RelayCommand]
    private void ShowTenants()
    {
        _tenants.ShowDefault();
        CurrentPage = _tenants;
        SelectOnly(nameof(IsTenantsSelected));
    }

    [RelayCommand]
    private void ShowUnits()
    {
        _units.ShowDefault();
        CurrentPage = _units;
        SelectOnly(nameof(IsUnitsSelected));
    }

    [RelayCommand]
    private void ShowGate()
    {
        CurrentPage = _gate;
        SelectOnly(nameof(IsGateSelected));
    }

    [RelayCommand]
    private void ShowReports()
    {
        _reports.ShowDefault();
        CurrentPage = _reports;
        SelectOnly(nameof(IsReportsSelected));
    }

    [RelayCommand]
    private void ShowSetup()
    {
        _setup.ShowDefault();
        CurrentPage = _setup;
        SelectOnly(nameof(IsSetupSelected));
    }

    [RelayCommand]
    private void ShowHelp()
    {
        CurrentPage = _help;
        SelectOnly(nameof(IsHelpSelected));
    }
}