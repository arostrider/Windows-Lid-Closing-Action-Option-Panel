# Windows-Lid-Closing-Action-Option-Panel
.NET Windows Form Application written in C# used for choosing displaying currently selected Windows Action (shut down, hibernate etc.) that is to be done on lap-top computer when the lid is closed.

This application is almost finished. At the moment, the application can set Windows lid closing action when the lap-top is on battery or pluged in for charging. This is done by using _System.Diagnostics.Process_ to open Windows Command Prompt and execute appropriate command.

Windows PowerShell (PS) script _Script_GetCurrentSetting.ps1_ is used to find current setting. In PS, it prints an integer (o, 1, 2 or 3) that denotes the action that is to be performed if the lid is closed. Instead of printing that integer in PS we need to send it to return it to function that will set the indicator text color accordingly to the integer value. I tried to use _System.Management.Automation.Runspaces_, _RunspaceInvoke_, _Pipeline_, _Command_ in first try and _PowerShell_, _Collection<PSObject>_, _StringBuilder_ in second try. Both codes are in _SettingsControl.cs_
  
  TO DO: Find the way to pass information about currently selected Windows setting to our application!
