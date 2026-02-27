using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Gate_Access_Management.ViewModels.Pages;
using Gate_Access_Management.ViewModels.Pages.Garages;
using Gate_Access_Management.ViewModels.Pages.Users;

namespace Gate_Access_Management.ViewModels;

public partial class ShellViewModel : ViewModelBase
{
    private readonly LogsViewModel _logs = new();
    private readonly UserHostViewModel _users = new();
    private readonly GarageHostViewModel _garages = new();
    private readonly GateViewModel _gate = new();
    private readonly ReportsViewModel _reports = new();
    private readonly SetupViewModel _setup = new();
    private readonly HelpViewModel _help = new();

    [ObservableProperty] private ViewModelBase _currentPage;

    [ObservableProperty] private bool _isLogsSelected;
    [ObservableProperty] private bool _isUsersSelected;
    [ObservableProperty] private bool _isGaragesSelected;
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
        IsUsersSelected = false;
        IsGaragesSelected = false;
        IsGateSelected = false;
        IsReportsSelected = false;
        IsSetupSelected = false;
        IsHelpSelected = false;

        if (name == nameof(IsLogsSelected)) IsLogsSelected = true;
        if (name == nameof(IsUsersSelected)) IsUsersSelected = true;
        if (name == nameof(IsGaragesSelected)) IsGaragesSelected = true;
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
    private void ShowUsers()
    {
        CurrentPage = _users;
        SelectOnly(nameof(IsUsersSelected));
    }

    [RelayCommand]
    private void ShowGarages()
    {
        CurrentPage = _garages;
        SelectOnly(nameof(IsGaragesSelected));
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
        CurrentPage = _reports;
        SelectOnly(nameof(IsReportsSelected));
    }

    [RelayCommand]
    private void ShowSetup()
    {
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