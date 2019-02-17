using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Calculator.Library
{
	/// <inheritdoc />
    /// <summary>
    /// Model base. base class to implement INotifyPropertyChanged 
    /// </summary>
	public class ModelBase : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged = delegate { };

		protected void RaiseAllPropertiesChanged()
		{
			// By convention, an empty string indicates all properties are invalid.
			PropertyChanged(this, new PropertyChangedEventArgs(string.Empty));
		}

		protected void RaisePropertyChanged<T>(Expression<Func<T>> propExpr)
		{
			var prop = (PropertyInfo)((MemberExpression)propExpr.Body).Member;
			RaisePropertyChanged(prop.Name);
		}

		protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}

		protected bool SetPropertyValue<T>(ref T storageField, T newValue, Expression<Func<T>> propExpr)
		{
			if (Equals(storageField, newValue))
				return false;

			storageField = newValue;
			var prop = (PropertyInfo)((MemberExpression)propExpr.Body).Member;
            RaisePropertyChanged(prop.Name);

			return true;
		}

		protected bool SetPropertyValue<T>(ref T storageField, T newValue, [CallerMemberName] string propertyName = "")
		{
			if (Equals(storageField, newValue))
				return false;

			storageField = newValue;
            RaisePropertyChanged(propertyName);

			return true;
		}

		//This method is called by the Set accessor of each property.
		//The CallerMemberName attribute that is applied to the optional propertyName
		//parameter causes the property name of the caller to be substituted as an argument.
		protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
		{
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
