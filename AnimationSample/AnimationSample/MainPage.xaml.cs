using Microsoft.Maui.Animations;

namespace AnimationSample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		var scaleAnimation = new Microsoft.Maui.Controls.Animation(OnUpdateAnimation, 0, 1, Easing.BounceIn, OnAnimationEnded);
		var animationManager = Handler.MauiContext.Services.GetRequiredService<IAnimationManager>();
		scaleAnimation.Commit(animationManager);	
	}

    private void OnAnimationEnded()
    {
		label.FontSize = 14;
    }

    private void OnUpdateAnimation(double obj)
    {
        label.FontSize = label.FontSize + 0.5;
    }
}

