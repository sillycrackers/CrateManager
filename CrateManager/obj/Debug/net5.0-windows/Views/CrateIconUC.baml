   M S B A M L   `   `   `  ����G  CCrateManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CrateManager.ViewModelsCrateManager.ViewModels  5      7 clr-namespace:CrateManager.ViewsCrateManager.Views  5      a ]PresentationFramework.Aero, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes 5      $    CrateManager.Views.CrateIconUC   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <
viewModels%clr-namespace:CrateManager.ViewModels     5      2views clr-namespace:CrateManager.Views     5      a
dropShadowJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero     5      .��5      � .+�5   
   �� -   5          ��Name$  MyButton��5      $	��150��5   1   $	��238��6>   $��10q�6J      	CrateBlue#��[  5      $
��Left=�69   $��Center=�6T   ��5      �� ��6%   ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" � �� Path$" DataContext.OpenCrateCommand���5      �� *ID+��5      �� 5       �� 
TargetType" ��6"   .R�5      � '  !System.Windows.VisualStateManager   VisualStateGroups 5      %  System.Windows.VisualStateGroup  5      CommonStates��   States. 5   "      System.Windows.VisualState  
Normal��   
Storyboard. 5   &   �� .��5   *   ��  �� 
TargetName$ BackgroundElement��69   	 �� TargetProperty$1	 +(Border.Background).(SolidColorBrush.Color)�5   9   	
 �� To#
 z��5   9    g� Duration$ 0:0:0.2D�6[   5    '   5!   #     5"   "   	MouseOver��. 5#   &   �� .��5$   *   �� $ BackgroundElement��69   $1	 +(Border.Background).(SolidColorBrush.Color)�5%   9   
 #0060875&   9   $ 0:0:0.2D�6F   5'   '   5(   #     5)   "   Pressed��. 5*   &   �� .��5+   *   �� $ BackgroundElement��69   $1	 +(Border.Background).(SolidColorBrush.Color)�5,   9   
 #0083b85-   9   $ 0:0:0.00D�6F   5.   '   5/   #   50      .+�53      5  /Microsoft.Windows.Themes.SystemDropShadowChrome     CornerRadius$ 5��6<   $��0��6M   $��0��6]   ._�54      ��  ��Name$ BackgroundElement��6%   #��z��6@    �� Padding$ 10q�55   %    �� CornerRadius$ 5��62   $��Stretch=�6C   $��Stretch=�56   %   ._�58   "   �� #��z��63   #��z��59   7   5:      5;      5<      5?      ��5B      �� 5C      .R�5D      �� $
��Left=�6!   $��Center=�6<   .+�5E      ��  ��Name$ 	CrateName��6$   $��20(�6M   $��5q�5F   $   
�������$
��Left=�6B   ��5E   7   �� *Name+5F   B   �� 5H      $ CrateCategory��6$   $��16(�6U   $��5q�5I   $   
�������$
��Left=�6B   ��5H   ;   �� *
Category+5I   B   �� 5K      $ KeyItems��6$   $
��Left=�6P   $��12(�5L   $   $��5q�62   
�������$
��Wrap=�6P   ��5K   6   �� *
KeyItems+5L   P   5M      5N      5Q      5R      5S      