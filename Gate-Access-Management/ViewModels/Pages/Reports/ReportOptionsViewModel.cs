using CommunityToolkit.Mvvm.Input;

namespace Gate_Access_Management.ViewModels.Pages.Reports;

public partial class ReportOptionsViewModel : ViewModelBase
{
    private readonly ReportHostViewModel _host;

    public override string PageTitle => "Reports";

    public ReportOptionsViewModel(ReportHostViewModel host)
    {
        _host = host;
    }

    [RelayCommand]
    private void ShowLogs() => _host.ShowLogsCommand.Execute(null);

    [RelayCommand]
    private void ShowRentals() => _host.ShowRentalsCommand.Execute(null);

    [RelayCommand]
    private void ShowTenants() => _host.ShowTenantsCommand.Execute(null);

    [RelayCommand]
    private void ShowUnits() => _host.ShowUnitsCommand.Execute(null);
}