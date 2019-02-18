
namespace Calculator.Library
{
	/// <inheritdoc />
    /// <summary>
    /// View model base. - this is base class for all viewModels
    /// </summary>
	public abstract class ViewModelBase : ModelBase
	{

		protected bool _isBusy;
		public bool IsBusy
		{
			get => _isBusy;
            set
			{
				_isBusy = value;

				NotifyPropertyChanged();
			}
		}

		protected string _message;
		public string Message
		{
			get => _message;
            set
			{
				_message = value;
				NotifyPropertyChanged();
			}

		}

	}
}
