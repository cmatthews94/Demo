# How To – Polystream SDK 102

### Overview

This page provides guidance on the prerequisites required getting started using the Polystream SDK and Toolkit.

For a more general overview of Polystream and our technology please see **Link to Learn about us page** before continuing.

For a more detailed technical overview please refer to **Link to more or less same body of text as the readme.html in the toolkit install**

**What is this about?**

I suggest removing this bit, use the one above and then go to prerequisites.

Polystream SDK is an utility that allows you to stream 3d applications without the use of video streaming. **Link to “Learn about us” page**

**Prerequisites**

*  A Windows 10 PC with a GPU capable of rendering to the requirements of the applications intended for streaming…blah..
*  An additional Windows PC for multi-PC setup.
*  An internet connection
*  …blah blah…this list needs to be representative and solid.

**Tutorials**

*   Basic set up for streaming from and to the same PC <Link to tutorial 1>
*   Set up for streaming between two PCs <Link to tutorial 2>
*   Set up for streaming from the cloud <Link to tutorial 3>

**Where to get help and additional links**

blah blah blah.

Move everything below into one or more Tutorial X pages. Each page can link to the previous one to build on that but consider making each page completely self -contained. Repetition isn’t always bad…

**What’s in the package?**

The package currently holds following files and folders:

![Folder Structure](https://secureservercdn.net/160.153.137.163/zjb.f38.myftpupload.com/wp-content/uploads/2020/06/image-11.png)

*   `server_x64` folder where the server libraries for 64-bit applications can be found
*   `server_x86` folder where the server libraries for 32-bit applications can be found
*   `psclient_native.exe` executable which is going to serve as our client receiving the stream

**How do I use it?**

In order to use the Polystream SDK to stream an application the following steps you have to prepare both the server (_machine you will be streaming from_) and client (_machine you’ll be streaming to_).

**Server Configuration**

For the best results we recommend that you use Windows Server 2012 as your server. First, let’s start with the supported application configuration and the addition of our libraries to the application you want to stream:

![Windowed Setting](https://secureservercdn.net/160.153.137.163/zjb.f38.myftpupload.com/wp-content/uploads/2020/06/image-12.png)

*   The application must be in Windowed Mode or Windowed Full-Screen. **Exclusive Full-Screen/Full-Screen is not supported.**

![Resolution](https://secureservercdn.net/160.153.137.163/zjb.f38.myftpupload.com/wp-content/uploads/2020/06/image-13.png)

*   Within the application options select the desired resolution that would work on the client monitor: e.g. `1920x1080`  

*   Navigate to the `server_x86` folder if your application is a 32-bit application, or the `server_x64` folder if your application is 64-bit.  

*   Copy the server DLL files based on the Graphics API the game uses (DirectX9 or DirectX11):  
    – For DirectX 9 applications: copy `d3d9.dll`, `audioses.dll`.  
    – For DirectX 11 applications: copy `d3d11.dll`, `dxgi.dll`, `audioses.dll`.

**Client Configuration**

Once we finished the server configuration – on the PC that will act as a client and will receive the stream of the application:

*   Create a new file called `config.cfg` **(shouldn’t we have it already, empty in the package? – Maria)** file found next to the `sclient_native.exe`

![Example config.cfg](https://secureservercdn.net/160.153.137.163/zjb.f38.myftpupload.com/wp-content/uploads/2020/06/image-14.png)

*   Type following values, each followed by a newline **(we should probably have them with example values?- Maria)**
*   – `window_size="HEIGHTxWIDTH"`where `HEIGHT` and `WIDTH` represent the resolution you chose when configuring the server application Eg. `window_size="1920x1080"`
*   – `server_address="X.X.X.X"` with the value representing the IPv4 address of your server.  
    **NOTE: You can also use a host-name if your client is able to resolve it/shares the DNS with the server**.

*   Copy the `config.cfg` file to the client machine together with the `psclient_native.exe` file.

**Starting the stream**

Once both sides are configured – you are ready to start the stream:

*   On the server machine, manually start the application by double clicking on the application native executable file. e.g. `Tanks.exe`  
    The application should start in the background at first.  

*   On the client machine, run `psclient_native.exe`

The client will now connect to the server and the streaming will start.

**That’s it!**

**Features:**

Version 0.1 **(versioning to be discussed/agreed? -Maria)**

*   Bespoke build, cannot be made to connect to our servers
*   Simple config (Only ‘server_address’ on client is actually required) 
*   Simple live stats output (Ctrl-F1) [MicroHud enabled, but Dataseer, etc. are not]
*   Polystream.log are output next to the client and/or server exes (Probably needs additional things logging)
*   Framepro DLLs are not required (Removed in production toolkit builds)
*   Large parts of code are #ifdef’ed out (Protection for our strings and protocols. Potentially more things need removing)

**Binaries:** **(storage location, site drive or Dropbox, or Azure storage? – Maria)**

**Source branch:** sr/toolkit

Version 0.2 **(versioning to be discussed/agreed? -Maria)** 
 
**New Features:**

*   Expanded live stats, and they are enabled by default
*   Support for XAudio2.9

**Binaries:** **(storage location, site drive or Dropbox, or Azure storage? – Maria)**
