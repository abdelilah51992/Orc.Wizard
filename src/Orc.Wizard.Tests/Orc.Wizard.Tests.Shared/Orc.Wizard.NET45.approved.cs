﻿[assembly: System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.5", FrameworkDisplayName=".NET Framework 4.5")]

namespace Orc.Wizard.Controls
{
    
    public sealed class BreadcrumbItem : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public static readonly System.Windows.DependencyProperty CurrentPageProperty;
        public static readonly System.Windows.DependencyProperty DescriptionProperty;
        public static readonly System.Windows.DependencyProperty NumberProperty;
        public static readonly System.Windows.DependencyProperty PageProperty;
        public static readonly System.Windows.DependencyProperty TitleProperty;
        public BreadcrumbItem() { }
        public Orc.Wizard.IWizardPage CurrentPage { get; set; }
        public string Description { get; set; }
        public int Number { get; set; }
        public Orc.Wizard.IWizardPage Page { get; set; }
        public string Title { get; set; }
        public void InitializeComponent() { }
    }
}
namespace Orc.Wizard.Converters
{
    
    public class BreadcrumbTitleConverter : Catel.MVVM.Converters.ValueConverterBase<Orc.Wizard.IWizardPage>
    {
        public BreadcrumbTitleConverter() { }
        protected override object Convert(Orc.Wizard.IWizardPage value, System.Type targetType, object parameter) { }
    }
    public class IsSelectedToBrushConverter : Catel.MVVM.Converters.ValueConverterBase<bool>
    {
        public IsSelectedToBrushConverter() { }
        protected override object Convert(bool value, System.Type targetType, object parameter) { }
    }
    public class IsSelectedToForegroundBrushConverter : Catel.MVVM.Converters.ValueConverterBase<bool>
    {
        public IsSelectedToForegroundBrushConverter() { }
        protected override object Convert(bool value, System.Type targetType, object parameter) { }
    }
    public class WizardPageToIsSelectedConverter : Catel.MVVM.Converters.ValueConverterBase<Orc.Wizard.IWizardPage>
    {
        public WizardPageToIsSelectedConverter() { }
        protected override object Convert(Orc.Wizard.IWizardPage value, System.Type targetType, object parameter) { }
    }
}
namespace Orc.Wizard
{
    
    public class static DefaultColorNames
    {
        public const string AccentColor = "AccentColor";
        public const string AccentColor4 = "AccentColor4";
        public const string AccentColorBrush = "AccentColorBrush";
        public const string AccentColorBrush4 = "AccentColorBrush4";
    }
    public class static DefaultColors
    {
        public static System.Windows.Media.Color AccentColor;
        public static System.Windows.Media.Color AccentColor4;
    }
    public class DefaultNavigationStrategy : Orc.Wizard.INavigationStrategy
    {
        public DefaultNavigationStrategy() { }
        public int GetIndexOfNextPage(Orc.Wizard.IWizard wizard) { }
        public int GetIndexOfPreviousPage(Orc.Wizard.IWizard wizard) { }
    }
    public class GeneralInformationWizardPage : Orc.Wizard.WizardPageBase
    {
        public static readonly Catel.Data.PropertyData CultureInfoProperty;
        public static readonly Catel.Data.PropertyData EndDateProperty;
        public static readonly Catel.Data.PropertyData FirstDayOfWeekProperty;
        public static readonly Catel.Data.PropertyData NameProperty;
        public static readonly Catel.Data.PropertyData ShortTimeFormatProperty;
        public static readonly Catel.Data.PropertyData StartDateProperty;
        public GeneralInformationWizardPage() { }
        public System.Globalization.CultureInfo CultureInfo { get; set; }
        public System.DateTime EndDate { get; set; }
        public System.DayOfWeek FirstDayOfWeek { get; set; }
        public string Name { get; set; }
        public string ShortTimeFormat { get; set; }
        public System.DateTime StartDate { get; set; }
    }
    public interface INavigationStrategy
    {
        int GetIndexOfNextPage(Orc.Wizard.IWizard wizard);
        int GetIndexOfPreviousPage(Orc.Wizard.IWizard wizard);
    }
    public interface ISummaryItem
    {
        string Summary { get; set; }
        string Title { get; set; }
    }
    public interface IWizard
    {
        bool CanCancel { get; }
        bool CanMoveBack { get; }
        bool CanMoveForward { get; }
        bool CanResume { get; }
        bool CanShowHelp { get; }
        Orc.Wizard.IWizardPage CurrentPage { get; }
        bool IsHelpVisible { get; }
        System.Windows.Size MaxSize { get; }
        System.Windows.Size MinSize { get; }
        Orc.Wizard.INavigationStrategy NavigationStrategy { get; }
        System.Collections.Generic.IEnumerable<Orc.Wizard.IWizardPage> Pages { get; }
        System.Windows.ResizeMode ResizeMode { get; }
        bool ShowInTaskbar { get; }
        string Title { get; }
        public event System.EventHandler<System.EventArgs> HelpShown;
        public event System.EventHandler<System.EventArgs> MovedBack;
        public event System.EventHandler<System.EventArgs> MovedForward;
        System.Threading.Tasks.Task CancelAsync();
        void InsertPage(int index, Orc.Wizard.IWizardPage page);
        System.Threading.Tasks.Task MoveBackAsync();
        System.Threading.Tasks.Task MoveForwardAsync();
        void RemovePage(Orc.Wizard.IWizardPage page);
        System.Threading.Tasks.Task SaveAsync();
        System.Threading.Tasks.Task ShowHelpAsync();
    }
    public class static IWizardExtensions
    {
        public static Orc.Wizard.IWizardPage AddPage(this Orc.Wizard.IWizard wizard, Orc.Wizard.IWizardPage page) { }
        public static TWizardPage AddPage<TWizardPage>(this Orc.Wizard.IWizard wizard)
            where TWizardPage : Orc.Wizard.IWizardPage { }
        public static Orc.Wizard.IWizardPage FindPage(this Orc.Wizard.IWizard wizard, System.Func<Orc.Wizard.IWizardPage, bool> predicate) { }
        public static TWizardPage FindPageByType<TWizardPage>(this Orc.Wizard.IWizard wizard)
            where TWizardPage : Orc.Wizard.IWizardPage { }
        public static TWizardPage InsertPage<TWizardPage>(this Orc.Wizard.IWizard wizard, int index)
            where TWizardPage : Orc.Wizard.IWizardPage { }
        public static bool IsFirstPage(this Orc.Wizard.IWizard wizard, Orc.Wizard.IWizardPage wizardPage = null) { }
        public static bool IsLastPage(this Orc.Wizard.IWizard wizard, Orc.Wizard.IWizardPage wizardPage = null) { }
    }
    public interface IWizardPage
    {
        string BreadcrumbTitle { get; set; }
        string Description { get; set; }
        bool IsOptional { get; }
        int Number { get; set; }
        string Title { get; set; }
        Catel.MVVM.IViewModel ViewModel { get; set; }
        Orc.Wizard.IWizard Wizard { get; set; }
        public event System.EventHandler<Orc.Wizard.ViewModelChangedEventArgs> ViewModelChanged;
        System.Threading.Tasks.Task CancelAsync();
        Orc.Wizard.ISummaryItem GetSummary();
        System.Threading.Tasks.Task SaveAsync();
    }
    public interface IWizardPageViewModelLocator : Catel.MVVM.ILocator, Catel.MVVM.IViewModelLocator { }
    public interface IWizardService
    {
        System.Threading.Tasks.Task<System.Nullable<bool>> ShowWizardAsync(Orc.Wizard.IWizard wizard);
    }
    public class static IWizardServiceExtensions
    {
        public static System.Threading.Tasks.Task<System.Nullable<bool>> ShowWizardAsync<TWizard>(this Orc.Wizard.IWizardService wizardService, object model = null)
            where TWizard : Orc.Wizard.IWizard { }
    }
    public class static ListBoxExtensions
    {
        public static readonly System.Windows.DependencyProperty HorizontalOffsetProperty;
        public static void CenterSelectedItem(this System.Windows.Controls.ListBox listBox) { }
        public static double GetHorizontalOffset(System.Windows.FrameworkElement target) { }
        public static void SetHorizontalOffset(System.Windows.FrameworkElement target, double value) { }
    }
    public class static ModuleInitializer
    {
        public static void Initialize() { }
    }
    public class static ProgressBarExtensions
    {
        public static readonly System.Windows.DependencyProperty SmoothProgressProperty;
        public static double GetSmoothProgress(System.Windows.FrameworkElement target) { }
        public static void SetSmoothProgress(System.Windows.FrameworkElement target, double value) { }
        public static void UpdateProgress(this System.Windows.Controls.ProgressBar progressBar, int currentItem, int totalItems) { }
    }
    public class SummaryItem : Orc.Wizard.ISummaryItem
    {
        public SummaryItem() { }
        public string Summary { get; set; }
        public string Title { get; set; }
    }
    public class SummaryWizardPage : Orc.Wizard.WizardPageBase
    {
        public SummaryWizardPage(Catel.Services.ILanguageService languageService) { }
    }
    public class ViewModelChangedEventArgs : System.EventArgs
    {
        public ViewModelChangedEventArgs(Catel.MVVM.IViewModel oldViewModel, Catel.MVVM.IViewModel newViewModel) { }
        public Catel.MVVM.IViewModel NewViewModel { get; }
        public Catel.MVVM.IViewModel OldViewModel { get; }
    }
    public abstract class WizardBase : Catel.Data.ModelBase, Orc.Wizard.IWizard
    {
        public static readonly Catel.Data.PropertyData CanShowHelpProperty;
        public static readonly Catel.Data.PropertyData IsHelpVisibleProperty;
        public static readonly Catel.Data.PropertyData MaxSizeProperty;
        public static readonly Catel.Data.PropertyData MinSizeProperty;
        public static readonly Catel.Data.PropertyData ResizeModeProperty;
        public static readonly Catel.Data.PropertyData ShowInTaskbarProperty;
        public static readonly Catel.Data.PropertyData TitleProperty;
        protected WizardBase(Catel.IoC.ITypeFactory typeFactory) { }
        public virtual bool CanCancel { get; }
        public virtual bool CanMoveBack { get; }
        public virtual bool CanMoveForward { get; }
        public virtual bool CanResume { get; }
        public bool CanShowHelp { get; set; }
        public Orc.Wizard.IWizardPage CurrentPage { get; }
        public bool IsHelpVisible { get; set; }
        public System.Windows.Size MaxSize { get; set; }
        public System.Windows.Size MinSize { get; set; }
        public Orc.Wizard.INavigationStrategy NavigationStrategy { get; set; }
        public System.Collections.Generic.IEnumerable<Orc.Wizard.IWizardPage> Pages { get; }
        public System.Windows.ResizeMode ResizeMode { get; set; }
        public bool ShowInTaskbar { get; set; }
        public string Title { get; set; }
        public event System.EventHandler<System.EventArgs> HelpShown;
        public event System.EventHandler<System.EventArgs> MovedBack;
        public event System.EventHandler<System.EventArgs> MovedForward;
        public virtual System.Threading.Tasks.Task CancelAsync() { }
        public void InsertPage(int index, Orc.Wizard.IWizardPage page) { }
        public virtual System.Threading.Tasks.Task MoveBackAsync() { }
        public virtual System.Threading.Tasks.Task MoveForwardAsync() { }
        protected override void OnPropertyChanged(Catel.Data.AdvancedPropertyChangedEventArgs e) { }
        public void RemovePage(Orc.Wizard.IWizardPage page) { }
        public virtual System.Threading.Tasks.Task SaveAsync() { }
        protected virtual Orc.Wizard.IWizardPage SetCurrentPage(int newIndex) { }
        public virtual System.Threading.Tasks.Task ShowHelpAsync() { }
    }
    public class static WizardConfiguration
    {
        public static System.TimeSpan AnimationDuration;
        public static readonly int CannotNavigate;
    }
    public abstract class WizardPageBase : Catel.Data.ModelBase, Orc.Wizard.IWizardPage
    {
        public static readonly Catel.Data.PropertyData BreadcrumbTitleProperty;
        public static readonly Catel.Data.PropertyData DescriptionProperty;
        public static readonly Catel.Data.PropertyData IsOptionalProperty;
        public static readonly Catel.Data.PropertyData NumberProperty;
        public static readonly Catel.Data.PropertyData TitleProperty;
        protected WizardPageBase() { }
        public string BreadcrumbTitle { get; set; }
        public string Description { get; set; }
        public bool IsOptional { get; set; }
        public int Number { get; set; }
        public string Title { get; set; }
        public Catel.MVVM.IViewModel ViewModel { get; set; }
        public Orc.Wizard.IWizard Wizard { get; set; }
        public event System.EventHandler<Orc.Wizard.ViewModelChangedEventArgs> ViewModelChanged;
        public virtual System.Threading.Tasks.Task CancelAsync() { }
        public virtual Orc.Wizard.ISummaryItem GetSummary() { }
        public virtual System.Threading.Tasks.Task SaveAsync() { }
    }
    public class WizardPageSelectionBehavior : Catel.Windows.Interactivity.BehaviorBase<System.Windows.Controls.ContentControl>
    {
        public static readonly System.Windows.DependencyProperty WizardProperty;
        public WizardPageSelectionBehavior() { }
        public Orc.Wizard.IWizard Wizard { get; set; }
        protected override void OnAssociatedObjectLoaded() { }
        protected override void OnAssociatedObjectUnloaded() { }
    }
    public class WizardPageViewModelBase<TWizardPage> : Catel.MVVM.ViewModelBase
        where TWizardPage :  class, Orc.Wizard.IWizardPage
    {
        public static readonly Catel.Data.PropertyData WizardPageProperty;
        public WizardPageViewModelBase(TWizardPage wizardPage) { }
        public Orc.Wizard.IWizard Wizard { get; }
        [Catel.MVVM.ModelAttribute()]
        public TWizardPage WizardPage { get; }
    }
    public class WizardPageViewModelLocator : Catel.MVVM.ViewModelLocator, Catel.MVVM.ILocator, Catel.MVVM.IViewModelLocator, Orc.Wizard.IWizardPageViewModelLocator
    {
        public WizardPageViewModelLocator() { }
    }
    public class WizardService : Orc.Wizard.IWizardService
    {
        public WizardService(Catel.Services.IUIVisualizerService uiVisualizerService) { }
        public System.Threading.Tasks.Task<System.Nullable<bool>> ShowWizardAsync(Orc.Wizard.IWizard wizard) { }
    }
}
namespace Orc.Wizard.ViewModels
{
    
    public class SummaryWizardPageViewModel : Orc.Wizard.WizardPageViewModelBase<Orc.Wizard.SummaryWizardPage>
    {
        public static readonly Catel.Data.PropertyData SummaryItemsProperty;
        public SummaryWizardPageViewModel(Orc.Wizard.SummaryWizardPage wizardPage) { }
        public System.Collections.ObjectModel.ObservableCollection<Orc.Wizard.ISummaryItem> SummaryItems { get; }
        protected override System.Threading.Tasks.Task InitializeAsync() { }
    }
    public class WizardViewModel : Catel.MVVM.ViewModelBase
    {
        public static readonly Catel.Data.PropertyData CurrentPageProperty;
        public static readonly Catel.Data.PropertyData IsFirstPageProperty;
        public static readonly Catel.Data.PropertyData IsHelpVisibleProperty;
        public static readonly Catel.Data.PropertyData IsLastPageProperty;
        public static readonly Catel.Data.PropertyData IsPageOptionalProperty;
        public static readonly Catel.Data.PropertyData MaxSizeProperty;
        public static readonly Catel.Data.PropertyData MinSizeProperty;
        public static readonly Catel.Data.PropertyData PageDescriptionProperty;
        public static readonly Catel.Data.PropertyData PageTitleProperty;
        public static readonly Catel.Data.PropertyData ResizeModeProperty;
        public static readonly Catel.Data.PropertyData ShowInTaskbarProperty;
        public static readonly Catel.Data.PropertyData WizardPagesProperty;
        public static readonly Catel.Data.PropertyData WizardProperty;
        public WizardViewModel(Orc.Wizard.IWizard wizard, Catel.Services.IMessageService messageService, Catel.Services.ILanguageService languageService) { }
        public Catel.MVVM.TaskCommand Cancel { get; set; }
        [Catel.MVVM.ViewModelToModelAttribute("Wizard", "CurrentPage")]
        public Orc.Wizard.IWizardPage CurrentPage { get; set; }
        public Catel.MVVM.TaskCommand Finish { get; set; }
        public Catel.MVVM.TaskCommand GoToNext { get; set; }
        public Catel.MVVM.TaskCommand GoToPrevious { get; set; }
        public bool IsFirstPage { get; }
        [Catel.MVVM.ViewModelToModelAttribute("Wizard", "IsHelpVisible")]
        public bool IsHelpVisible { get; set; }
        public bool IsLastPage { get; }
        public bool IsPageOptional { get; }
        [Catel.MVVM.ViewModelToModelAttribute("Wizard", "MaxSize")]
        public System.Windows.Size MaxSize { get; set; }
        [Catel.MVVM.ViewModelToModelAttribute("Wizard", "MinSize")]
        public System.Windows.Size MinSize { get; set; }
        public string PageDescription { get; }
        public string PageTitle { get; }
        [Catel.MVVM.ViewModelToModelAttribute("Wizard", "ResizeMode")]
        public System.Windows.ResizeMode ResizeMode { get; set; }
        public Catel.MVVM.TaskCommand ShowHelp { get; set; }
        [Catel.MVVM.ViewModelToModelAttribute("Wizard", "ShowInTaskbar")]
        public bool ShowInTaskbar { get; set; }
        [Catel.MVVM.ModelAttribute(SupportIEditableObject=false)]
        public Orc.Wizard.IWizard Wizard { get; set; }
        public System.Collections.Generic.IEnumerable<Orc.Wizard.IWizardPage> WizardPages { get; }
        public Orc.Wizard.IWizardPage get_CurrentPage() { }
        public bool get_IsHelpVisible() { }
        public System.Windows.Size get_MaxSize() { }
        public System.Windows.Size get_MinSize() { }
        public System.Windows.ResizeMode get_ResizeMode() { }
        public bool get_ShowInTaskbar() { }
        protected override System.Threading.Tasks.Task InitializeAsync() { }
        public void set_CurrentPage(Orc.Wizard.IWizardPage ) { }
        public void set_IsHelpVisible(bool ) { }
        public void set_MaxSize(System.Windows.Size ) { }
        public void set_MinSize(System.Windows.Size ) { }
        public void set_ResizeMode(System.Windows.ResizeMode ) { }
        public void set_ShowInTaskbar(bool ) { }
    }
}
namespace Orc.Wizard.Views
{
    
    public class SummaryWizardPageView : Catel.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public SummaryWizardPageView() { }
        public void InitializeComponent() { }
    }
    public class WizardWindow : Catel.Windows.DataWindow, System.Windows.Markup.IComponentConnector
    {
        public WizardWindow() { }
        public WizardWindow(Orc.Wizard.ViewModels.WizardViewModel viewModel) { }
        public void InitializeComponent() { }
        protected override void OnLoaded(System.EventArgs e) { }
        protected override void OnViewModelPropertyChanged(System.ComponentModel.PropertyChangedEventArgs e) { }
    }
}