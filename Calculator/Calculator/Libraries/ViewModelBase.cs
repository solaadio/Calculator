
namespace Calculator.Libraries
{
	/// <summary>
	/// View model base. - this is base class for all viewModels
	/// </summary>
	public abstract class ViewModelBase : ModelBase
	{

		protected bool _isBusy;
		public bool IsBusy
		{
			get { return _isBusy; }
			set
			{
				_isBusy = value;

				NotifyPropertyChanged("IsBusy");
			}
		}

		protected string _message;
		public string Message
		{
			get { return _message; }
			set
			{
				_message = value;
				NotifyPropertyChanged("Message");
			}

		}

	}
}
