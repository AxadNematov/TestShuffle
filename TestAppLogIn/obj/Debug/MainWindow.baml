   M S B A M L   `   `   `  ����G  CTestAppLogIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TestAppLogInTestAppLogIn  5   	       TestAppLogIn.MainWindow   5   	   a ]DevExpress.Xpf.Core.v20.1, Version=20.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:TestAppLogIn     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Log In��5	   	   $	��500��6   $	��350��6%    � 
ResizeMode$ NoResize=�61    � WindowStartupLocation$ CenterScreen=�6G    � WindowStyle$
 None=�6l   .��5
      � .+�5   
   �� $	��280��6   $	��Top=�6!   ��5      �� 5       �� EndPoint$ 0,5.1&�6&    �� 
StartPoint$ 0.5, 0&�67   .��5      �  � Color$ 	#FF2281D1��6#   � 5      $ 	#FF34268A��6#    � Offset$ 1Q�65   � 5      $ 	#FF33288B��6#   $	 0.5Q�65   5      5      �� 5   
   $��Data/images.png��6   $	��100��6)   $	��100��65   $	��Top=�6B   $��20q�6Z   �� 5   
   $	��280��6   $	��240��6    
�������$��Bottom=�6:   $��0,100q�6U    �� RadiusY$ 16��6d   	 �� RadiusX$	 16��6q   
 J� Effect
 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ 	#FFBBBBBB��6#      	Direction$ 0Q�65      
BlurRadius$ 15Q�6C      RenderingBias$ Quality=�6S      ShadowDepth$ 1Q�6k   5      � 5   
   $	��280��6   $	��240��6   $��Bottom=�6(   $��0,100q�6C   .+�5      �� $��LOGIN��6   $��Center=�6%   $	��Top=�6B   $��5q�6Z   
�������$��18(�6w   �� 5      $��Center=�6   $��10q�64   .+�5      �� -   5         ��Name$
 mail��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ EMAIL��6(    %  !MaterialDesignFloatingHintTextBox#��[  6O   $
��0,10q�6�   $��Nirmala UI Semilight)�6�   $��16(�6�   G� 5      -   5         G�Name$ password��5      $ PASSWORD��60    ) %MaterialDesignFloatingHintPasswordBox#��[ 6Z   $
��0,10q�6�   $��Nirmala UI Semilight)�6�   $��16(�6�   5      5       �� 5!   
   -   5        $��Bottom=�5!      $
��0,85q�6,   $	��150��6:   $��LOGIN��6F   ���	#FF3F76EC6m   �� 5"   
   $��Forgot password?��6   $��Center=�6,   $��Bottom=�6I   $��50q�6d   
������� � Cursor$
 Hand��6�   5#      5$      