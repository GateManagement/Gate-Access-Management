using CommunityToolkit.Mvvm.Input;

namespace Gate_Access_Management.ViewModels.Pages.Setup;

public partial class SetupOptionsViewModel : ViewModelBase
{
    private readonly SetupHostViewModel _host;

    public override string PageTitle => "Setup";

    public SetupOptionsViewModel(SetupHostViewModel host)
    {
        _host = host;
    }

    [RelayCommand]
    private void ShowAccessSchedules() => _host.ShowAccessSchedulesCommand.Execute(null);

    [RelayCommand]
    private void ShowUnitTypes() => _host.ShowUnitTypesCommand.Execute(null);

    [RelayCommand]
    private void ShowSettings() => _host.ShowSettingsCommand.Execute(null);
}