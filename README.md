# DialogMessage
A homemade messagebox for Windows

![Message](Message.png?raw=true "Message")

### Read the accompanying article on CodeProject <a href="https://www.codeproject.com/Articles/5264875/Dialog-Message-in-Csharp-for-NET-Framework-4-5" target="_blank">here</a>

<p>This repository may be ahead of the CodeProject article due to new features and revisions</p>

# Implementation

```csharp
using DialogMessage;

if (DMessage.ShowMessage(

    // Window Title
    "Window Title",

    // Main Instruction
    "Want to learn how to write your own message box?",

    // Dialog buttons
    DMessage.MsgButtons.YesNo,

    // Dialog Icons
    DMessage.MsgIcons.Question,

    // Content
    "In this project we will learn the logic necessary " +
    "to write your own dialog message box in Windows")

    // Checks DialogResult of the button clicked by user
    == DialogResult.Yes)

    // Show the Windows standard MessageBox to test result
    MessageBox.Show("You clicked Yes!");

else

    MessageBox.Show("You clicked No!");
```

### Supports six image configurations in an `enum`
```csharp
// Message icon enum for switch statement in ShowMessage
// This will set the Image for the PictureBox
public enum MsgIcons
{
    None = 0,
    Question = 1,
    Info = 2,
    Warning = 3,
    Error = 4,
    Shield = 5
}
```
### Supports three button configurations in an `enum`
```csharp
// Message button enum for switch statement in ShowMessage
// This will set the properties of the form buttons and their DialogResult
public enum MsgButtons
{
    OK = 0,
    OKCancel = 1,
    YesNo = 2
}
```
