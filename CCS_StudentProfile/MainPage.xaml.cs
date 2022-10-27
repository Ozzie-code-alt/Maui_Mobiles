namespace CCS_StudentProfile;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		if(vsLog1.HeightRequest != 0) //onclick if height is not 0
		{
			vsLog1.HeightRequest = 0;
			vsLog1.WidthRequest = 0;
			vsLog1.Spacing = 0;

			Username.HeightRequest = 0;
			Username.WidthRequest = 0;
			Password.HeightRequest = 0;
			Password.WidthRequest = 0;
			imbShowPassword.HeightRequest = 0;	
		}
		else //height was 0 by default soo it went here
		{
            vsLog1.HeightRequest = 100;
            vsLog1.WidthRequest = 250;
            vsLog1.Spacing = 15;

            Username.HeightRequest = 50;
            Username.WidthRequest = 250;


            Password.HeightRequest = 50;
            Password.WidthRequest = 250;
            imbShowPassword.HeightRequest = 15;
        }
	}
}

