using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace Controls
{
    public partial class TimerView
    {
		#region Bindable properties

		public static readonly BindableProperty TrackBarProperty =
			BindableProperty.Create(
				"TrackBar", typeof(View), typeof(TimerView),
				defaultValue: null);

		public View TrackBar
		{
			protected get { return (View)GetValue(TrackBarProperty); }
			set { SetValue(TrackBarProperty, value); }
		}

		public static readonly BindableProperty ProgressBarProperty =
			BindableProperty.Create(
				"ProgressBar", typeof(View), typeof(TimerView),
				defaultValue: null);

		public View ProgressBar
		{
			protected get { return (View)GetValue(ProgressBarProperty); }
			set { SetValue(ProgressBarProperty, value); }
		}

		public static readonly BindableProperty TimerLabelProperty =
			BindableProperty.Create(
				"TimerLabel", typeof(Label), typeof(TimerView),
				defaultValue: default(Label));

		public Label TimerLabel
		{
			protected get { return (Label)GetValue(TimerLabelProperty); }
			set { SetValue(TimerLabelProperty, value); }
		}

		public static readonly BindableProperty StartTimerCommandProperty =
			BindableProperty.Create(
				"StartTimerCommand", typeof(ICommand), typeof(TimerView),
				defaultBindingMode: BindingMode.OneWayToSource,
				defaultValue: default(ICommand));

		public ICommand StartTimerCommand
		{
			get { return (ICommand)GetValue(StartTimerCommandProperty); }
			protected set { SetValue(StartTimerCommandProperty, value); }
		}

		public static readonly BindableProperty PauseTimerCommandProperty =
			BindableProperty.Create(
				"PauseTimerCommand", typeof(ICommand), typeof(TimerView),
				defaultBindingMode: BindingMode.OneWayToSource,
				defaultValue: default(ICommand));

		public ICommand PauseTimerCommand
		{
			get { return (ICommand)GetValue(PauseTimerCommandProperty); }
			protected set { SetValue(PauseTimerCommandProperty, value); }
		}

		public static readonly BindableProperty StopTimerCommandProperty =
			BindableProperty.Create(
				"StopTimerCommand", typeof(ICommand), typeof(TimerView),
				defaultBindingMode: BindingMode.OneWayToSource,
				defaultValue: default(ICommand));

        public ICommand StopTimerCommand
		{
			get { return (ICommand)GetValue(StopTimerCommandProperty); }
			protected set { SetValue(StopTimerCommandProperty, value); }
		}

		public static readonly BindableProperty RemainingTimeProperty =
			BindableProperty.Create(
				"RemainingTime", typeof(TimeSpan), typeof(TimerView),
				defaultBindingMode: BindingMode.OneWayToSource,
				defaultValue: default(TimeSpan));

		public TimeSpan RemainingTime
		{
			get { return (TimeSpan)GetValue(RemainingTimeProperty); }
			protected set { SetValue(RemainingTimeProperty, value); }
		}

		public static readonly BindableProperty AutoStartProperty =
            BindableProperty.Create(
                "AutoStart", typeof(bool), typeof(TimerView),
                defaultValue: default(bool));

        public bool AutoStart
        {   
            get { return (bool)GetValue(AutoStartProperty); }
            set { SetValue(AutoStartProperty, value); }
        }

        public static readonly BindableProperty TimeProperty =
            BindableProperty.Create(
                "Time", typeof(TimeSpan), typeof(TimerView),
                defaultValue: TimeSpan.FromSeconds(30));

        public TimeSpan Time
        {
            get { return (TimeSpan)GetValue(TimeProperty); }
            set { SetValue(TimeProperty, value); }
        }

    public static readonly BindableProperty IsTimerRunningProperty =
        BindableProperty.Create(
            "IsTimerRunning", typeof(bool), typeof(TimerView),
            defaultBindingMode: BindingMode.OneWayToSource,
            defaultValue: default(bool), propertyChanged: OnIsTimerRunningChanged);

    public bool IsTimerRunning
    {
        get { return (bool)GetValue(IsTimerRunningProperty); }
        protected set { SetValue(IsTimerRunningProperty, value); }
    }

    private static void OnIsTimerRunningChanged(BindableObject bindable, object oldValue, object newValue)
    {
        ((TimerView)bindable).OnIsTimerRunningChangedImpl((bool)oldValue, (bool)newValue);
    }

		#endregion
	}
}
