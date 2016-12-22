# Rounded Corner ProgressBar for WinForm
Rounded Corner ProgressBar is a custom control inherited from 'PictureBox' for WinForm with animation.
Main purpose of the component is to have a smooth animation and proper curved edges in progressbar.

### TO INSTALL THE LIBRARY
This library is available as a NuGet package at [nuget.org](https://www.nuget.org/packages/RoundCornerProgressBar/).

### INSTRUCTIONS
Use toolbox to add the control to your forms.

Check 'RCProgressBarExamples' project for more examples.

![animation](/animation.gif?raw=true "animation")

### CONTROL PROPERTIES
#####[Properties]

* `RoundCorneredProgressBar.Value`: Value to be shown in progress bar.
* `RoundCorneredProgressBar.ProgressFontColor`: Font Color of the progress shown.
* `RoundCorneredProgressBar.ProgressFont`: Set the font style of the progress percentage.
* `RoundCorneredProgressBar.ProgressBackColor`: set the backcolor of the progressbar.
* `RoundCorneredProgressBar.ProgressBarColor`: set the bar color of the progressbar.

#####[Methods]

* `RoundCorneredProgressBar.Animate`: Starts the smooth animatioin of filling progress.
