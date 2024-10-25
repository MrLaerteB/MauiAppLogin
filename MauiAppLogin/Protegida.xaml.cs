using static System.Net.Mime.MediaTypeNames;
using System.Security.Claims;

using System.Xml.Linq;

<? xml version = "1.0" encoding = "utf-8" ?>
< ContentPage xmlns = "http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns: x = "http://schemas.microsoft.com/winfx/2009/xaml"
             x: Class = "MauiAppLogin.Protegida"
             Title = "Protegida" >


    < VerticalStackLayout VerticalOptions = "Center"
                         Padding = "10" Spacing = "10" >
        < Frame >
            < VerticalStackLayout >
                < Label Text = "�rea Protegida"
                       FontSize = "Large"
                       HorizontalTextAlignment = "Center" />
                < Label x: Name = "lbl_boasvindas"
                       HorizontalTextAlignment = "Center" />
                < Button Text = "Desconectar"
                        Clicked = "Button_Clicked"
                        HorizontalOptions = "Center"
                        />
            </ VerticalStackLayout >
        </ Frame >
    </ VerticalStackLayout >


</ ContentPage >