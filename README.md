NavigationParameters
====================

A tentative implementation for a cross-platform way to control view presentation in MvvmCross.
For example, clearing the back stack or show the view without adding it to back-stack.

Android only for now.


Android
----------

Some background:

In MvvmCross, the default MvxAndroidViewsContainer handles the view requests from presenter:

https://github.com/MvvmCross/MvvmCross/blob/e6d10972b5c28e00e80acc3d9e8910961aa813d6/Cirrious/Cirrious.MvvmCross.Droid/Views/MvxAndroidViewsContainer.cs#L145

Which is called by MvxAndroidViewPresenter:

https://github.com/MvvmCross/MvvmCross/blob/e6d10972b5c28e00e80acc3d9e8910961aa813d6/Cirrious/Cirrious.MvvmCross.Droid/Views/MvxAndroidViewPresenter.cs#L45
https://github.com/MvvmCross/MvvmCross/blob/e6d10972b5c28e00e80acc3d9e8910961aa813d6/Cirrious/Cirrious.MvvmCross.Droid/Views/MvxAndroidViewPresenter.cs#L28

In NavigationParameters, <code>MvxAndroidViewsContainer</code> is subclassed and <code>AdjustIntentForPresentation</code> overriden.
