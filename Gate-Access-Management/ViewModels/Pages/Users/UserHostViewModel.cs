using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Gate_Access_Management.ViewModels.Pages.Users;

public partial class UserHostViewModel : ViewModelBase
{
    public UserListViewModel List { get; } = new();
    public UserCreateViewModel Create { get; } = new();
    public UserDetailsViewModel Details { get; } = new();

    [ObservableProperty]
    private ViewModelBase _currentView;

    public UserHostViewModel()
    {
        _currentView = List;
    }

    [RelayCommand]
    private void ShowList() => CurrentView = List;

    [RelayCommand]
    private void ShowCreate() => CurrentView = Create;

    [RelayCommand]
    private void ShowDetails() => CurrentView = Details;
}