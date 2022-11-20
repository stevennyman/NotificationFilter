![NotificationFilter logo](Untitled.png)
# NotificationFilter
By Steven Nyman

Automatically dismisses notiifcations containing the text "This site was updated in the background." from Chromium-based web browsers on Windows 10 and Windows 11. These
pointless notifications, which cannot be disabled without disabling all other notifications from your web browser, are shown when a web app receives a push message but
does not show a notification.

This application has no user interface (except for an About screen) and quietly sits in your system tray.

## Installation
First, download the provided `.msixbundle` file from releases. Follow [these steps](https://www.advancedinstaller.com/install-test-certificate-from-msix.html)
to trust the certificate used to sign it and to enable installation. Once you have finished those steps, double click on the `.msixbundle` file and install it.

## FAQ
### Why is NotificationFilter packaged as an `.msixbundle` file?
In order to listen for notifications, Windows requires applications to have a "package identity" and be enabled for the "User Notification Listener" capability.
Unfortunately this cannot be done with traditional installers or portable application packages, so the application is packaged as a `.msixbundle` file.

### Why is the `.msixbundle` file so large?
The `.msixbundle` file includes a copy of all of the .NET 7 runtime files needed to run the application, which are quite large.

### Can the app be started from the command line?
Yes, run the `notificationfilter` command. Also, the app will automatically run on startup.