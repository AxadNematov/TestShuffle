   M S B A M L   `   `   `  ����G  CTestAppLogIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TestAppLogInTestAppLogIn  5   	       TestAppLogIn.Window1   5   	   a ]DevExpress.Xpf.Core.v20.1, Version=20.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :xctk)http://schemas.xceed.com/wpf/xaml/toolkit     5   	   a ]Syncfusion.Shared.Wpf, Version=18.4451.0.33, Culture=neutral, PublicKeyToken=3d67ed1f87d44c892
syncfusion!http://schemas.syncfusion.com/wpf  5   	   &localclr-namespace:TestAppLogIn  5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   $	��700��5
      $
��1200��6'     � 
ResizeMode$  NoResize=�64    � WindowStartupLocation$ CenterScreen=�6J    � WindowStyle$ SingleBorderWindow=�6o   
������� � 	Resources 5         MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose��%   &	        &	 u    �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 60Q�63     5      $ 0:0:0.5��6'   $ 60Q�69   5      U� 5      $ (FrameworkElement.Width)�6,   $ richTextBox��6a   .\�5        $ 0��6'   $
 1052Q�63     5      $ 0:0:0.5��6'   $
 1052Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 200Q�63     5      $ 0:0:0.5��6'   $	 200Q�69   5      U� 5      $ (FrameworkElement.Width)�6,   $ richTextBox��6a   .\�5        $ 0��6'   $
 1052Q�63     5      $ 0:0:0.5��6'   $
 1052Q�69   5      5      5        � Triggers 5"      :� 5#   
   	 :� RoutedEvent$	 ButtonBase.Click��6   
 :� 
SourceName$
 ButtonOpenMenu��66   .[�5$      �� #��[  6   5%      :� 5&   
   $	 ButtonBase.Click��6   $
 ButtonCloseMenu��66   .[�5'      �� #��[ 6   5(      .��5+      � 
�������.+�5,   
   � $��70��6   $	��Top=�6   ���	#FF3C699E.+�5-      �� -   5         ��Name$ 
personMail��5-      $��Design��6,   $��Center=�6:   $��Center=�6W   $��22(�6r   6�   �� 5.      $��Center=�6    �� Orientation$ 
Horizontal=�64   $��Right=�6M   .+�5/      �� $�� ��6   $��Center=�6$   $��14(�6?   '  !MaterialDesignThemes.Wpf.PopupBox  50      $��10q�6*      PlacementMode$ BottomAndAlignRightEdges=�66      	StaysOpen .     PopupContent. 51      �� .+�52      �� $��Account��6!   65   �� 53      $��Settings��6!   66   �� 54      $
��Help��6!   62   �� 55      �� 56      -   5         ��Name$ ButtonLogout��56   !   $��Logout��67   6e   57      58      5:      5;      � 5<   
   -   5         �Name$ GridMenu��5<      $��60��6!   $
��Left=�6,   
�������.+�5=      �� .+�5>      � $��69��6   
�������.+�5?      �� -   5        $ ButtonCloseMenu��5?      $��60��66   $��60��6A   $	��Top=�6z   $��Right=�6�   $y�	Collapsed=�6�   ��6M   Z� ��6c   Z� .��5@      '  !MaterialDesignThemes.Wpf.PackIcon  ���	#FF173C68   Kind$ 	ArrowLeft=�6I   $��25��6Z   $��25��6e   5A      �� 5B      -   5        $ ButtonOpenMenu��5B      $��60��65   $��60��6@   $	��Top=�6y   $��Right=�6�   ��6L   Z� ��6b   Z� .��5C        ���	#FF173C68$
 Menu=�6I   $��25��6U   $��25��6`   5D      5E      � 5F      $��69��6   
�������.+�5G      �� -   5        $ ButtonUpload��5G      $��60��63   $��60��6>   $	��Top=�6w   $��Right=�6�   ��6J   Z� ��6`   Z� .��5H        ���	#FF173C68$ Upload=�6I   $��25��6W   $��25��6b   5I      5J      � 5K      $��69��6   
�������.+�5L      �� -   5        $ cmdUp��5L      $��0,0,0,0q�6F   $��55��6W   $��Center=�6b   $��Center=�6�   $��19��6�   
�������$��0q�6�   $��6(�6�   $��UltraExpanded&�6�   $	��Top=�6  .��5M      �� $��^��6$    �� TextAlignment$
 Left=�6-   $��9(�6B   5N      �� 5O      -   5         ��Name$ txtNum��5O      $��	0,22,0,17q�6H   $
��Left=�6[   $��58��6v   $��0��6�   ���	#FF0A0A0A6�   �� 5P      -	   5        $ cmdDown��5P      $��0,0,0,0q�6H   $��55��6Y   $��Center=�6d   $��Center=�6�   $��19��6�   
�������$��0q�6�   $��6(�6�   $��UltraExpanded&�6   $��Bottom=�6  .��5Q      �� $��˅��6$   $
 Left=�6-   $��9(�6B   5R      5S      � 5T      $��69��6   
�������.+�5U      �� -
   5        $ ButtonShuffle��5U      $��60��64   $��60��6?   $	��Top=�6x   $��Right=�6�   ��6K   Z� ��6a   Z� .��5V        ���	#FF173C68$ Refresh=�6I   $��25��6X   $��25��6c   5W      5X      � 5Y      $��69��6   
�������.+�5Z      �� -   5        $ ButtonDownload��5Z      $��60��65   $��60��6@   $	��Top=�6y   $��Right=�6�   ��6L   Z� ��6b   Z� .��5[        ���	#FF173C68$ Download=�6I   $��25��6Y   $��25��6d   5\      5]      5^      5_      �� 5`   
   -   5         ��Name$ richTextBox��5`      $��Right=�6+   $	��589��6G   $��	0,80,40,0q�6T   $	��Top=�6g   $
��1052��6    �� IsDocumentEnabled . $��16(�6�   
�������. �5a      /�  �� 	AllowDrop .   /� 
Foreground
 �   �6-   5b      � 5c   
   -   5        $��pbStatus��5c   0    � Minimum$ 0Q�6    � Maximum$	 100Q�6"   $
��Left=�6@   $��8��6[   $��	60,70,0,0q�6f   $	��Top=�6y   $
��1134��6�    � IsIndeterminate . $y�	Collapsed=�6�   5d      5e      