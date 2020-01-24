# UIModalPresentationStyleFormSheetOnAppearingRepro

A Xamarin.Forms sample reproducing a bug where `OnAppearing` does not fire with a `UIModalPresentationStyle.FormSheet` Page is dismissed

## Reproduction Steps

1. Download/Clone this repo
2. In Visual Studio, open `OnAppearingRepro.sln`
3. Build/deploy `OnAppearingRepro.iOS` to an iOS Simulator or Device
4. On the iOS app, confirm the following alert appears: `OnAppearing Fired`
5. On the iOS app, dismiss the alert
6. On the iOS app, click the `Push Page` Button to push a new `ContentPage` via `Navigation.PushAsync`
7. On the iOS app, click the `Back` button
8. On the iOS app, confirm the following alert appears: `OnAppearing Fired`
9. On the iOS app, dismiss the alert
10. On the iOS app, click the `Push Modal Full Screen Sheet Page` Button to push a new `ContentPage` using `UIModalPresentationStyle.FullScreen` via `Navigation.PushModalAsync`
11. On the iOS app, click the `Back` button
12. On the iOS app, confirm the following alert appears: `OnAppearing Fired`
13. On the iOS app, dismiss the alert
14. On the iOS app, click the `Push Modal Form Sheet Page` Button to push a new `ContentPage` using `UIModalPresentationStyle.FormSheet` via `Navigation.PushModalAsync`
15. On the iOS app, click the `Back` button
16. On the iOS app, confirm the following alert *does not* appear: `OnAppearing Fired`

![](https://user-images.githubusercontent.com/13558917/73046661-59377c80-3eb6-11ea-916a-494469969d85.gif)

## Environment

=== Visual Studio Enterprise 2019 for Mac ===

Version 8.4.2 (build 59)
Installation UUID: a2b6d174-e0ee-438a-9e9d-eec8b8dd47da
	GTK+ 2.24.23 (Raleigh theme)
	Xamarin.Mac 5.16.1.25 (issue-7441-d16-3-vsmac / 881172e73)

	Package version: 606000155

=== Mono Framework MDK ===

Runtime:
	Mono 6.6.0.155 (2019-08/296a9afdb24) (64-bit)
	Package version: 606000155

=== Roslyn (Language Service) ===

3.4.0-beta4-19562-05+ff930dec4565e2bc424ad3bf3e22ecb20542c87d

=== NuGet ===

Version: 5.3.0.6192

=== .NET Core SDK ===

SDK: /usr/local/share/dotnet/sdk/3.1.101/Sdks
SDK Versions:
	3.1.101
	3.1.100
	3.0.101
	2.1.803
MSBuild SDKs: /Library/Frameworks/Mono.framework/Versions/6.6.0/lib/mono/msbuild/Current/bin/Sdks

=== .NET Core Runtime ===

Runtime: /usr/local/share/dotnet/dotnet
Runtime Versions:
	3.1.1
	3.1.0
	3.0.1
	2.1.15
	2.1.14

=== Xamarin.Profiler ===

Version: 1.6.13.11
Location: /Applications/Xamarin Profiler.app/Contents/MacOS/Xamarin Profiler

=== Updater ===

Version: 11

=== Apple Developer Tools ===

Xcode 11.3.1 (15715)
Build 11C504

=== Xamarin.Mac ===

Xamarin.Mac not installed. Can't find /Library/Frameworks/Xamarin.Mac.framework/Versions/Current/Version.

=== Xamarin.iOS ===

Version: 13.10.0.17 (Visual Studio Enterprise)
Hash: 5f802ef53
Branch: xcode11.3
Build date: 2020-01-07 11:53:06-0500

=== Xamarin Designer ===

Version: 16.4.0.478
Hash: 95f0ab363
Branch: remotes/origin/d16-4
Build date: 2020-01-08 23:59:46 UTC

=== Xamarin.Android ===

Version: 10.1.3.7 (Visual Studio Enterprise)
Commit: xamarin-android/d16-4/d66aed0
Android SDK: /Users/bramin/Library/Developer/Xamarin/android-sdk-macosx
	Supported Android versions:
		7.0 (API level 24)

SDK Tools Version: 26.1.1
SDK Platform Tools Version: 29.0.5
SDK Build Tools Version: 29.0.2

Build Information: 
Mono: fd9f379
Java.Interop: xamarin/java.interop/d16-4@c4e569f
ProGuard: xamarin/proguard/master@905836d
SQLite: xamarin/sqlite/3.28.0@46204c4
Xamarin.Android Tools: xamarin/xamarin-android-tools/master@9f4ed4b

=== Microsoft Mobile OpenJDK ===

Java SDK: /Users/bramin/Library/Developer/Xamarin/jdk/microsoft_dist_openjdk_1.8.0.25
1.8.0-25
Android Designer EPL code available here:
https://github.com/xamarin/AndroidDesigner.EPL

=== Android SDK Manager ===

Version: 16.4.0.9
Hash: 3f7256f
Branch: remotes/origin/d16-4
Build date: 2020-01-14 22:19:04 UTC

=== Android Device Manager ===

Version: 16.4.0.30
Hash: f9172e2
Branch: remotes/origin/d16-4
Build date: 2020-01-14 22:19:24 UTC

=== Xamarin Inspector ===

Version: 1.4.3
Hash: db27525
Branch: 1.4-release
Build date: Mon, 09 Jul 2018 21:20:18 GMT
Client compatibility: 1

=== Build Information ===

Release ID: 804020059
Git revision: eb6fcdd83a227678e487aa733df3c8745f54fafc
Build date: 2020-01-17 12:12:02+00
Build branch: release-8.4
Xamarin extensions: ec32c90978c94f03d72f507b01f5aee70952ce87

=== Operating System ===

Mac OS X 10.15.2
Darwin 19.2.0 Darwin Kernel Version 19.2.0
    Sat Nov  9 03:47:04 PST 2019
    root:xnu-6153.61.1~20/RELEASE_X86_64 x86_64

