   M S B A M L   `   `   `  ����A  =WPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFAppWPFApp  5      #    WPFApp.UserControlPackageEdit   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:WPFApp     5      V RMaterialDesignThemes.Wpf, Version=3.1.2.1465, Culture=neutral, PublicKeyToken=nullZ VMaterialDesignThemes.MahApps, Version=0.1.2.1465, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5      T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f6mah,http://metro.mahapps.com/winfx/xaml/controls  5      .��5      � -   5        .+�5   
   �� $��15q�6   $	��400��6   
�������$��Center=�6?     �� Padding$  30q�6Z    �� CornerRadius$ 10��6g   $	��800��6y    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ 	LightGray��63      ShadowDepth$ 0Q�6E   ._�5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TrainsitionigContentSlide��5   2   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6U   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration 0:0:0.8.��5      � 	 � RowDefinitions	 5      �� 5      $��30 �6(   66   �� 5      $��30 �6(   66   �� 5      6*   .+�5      �� -   5        
 ��Name$
 packagesComboBox��5   ,   $��0��6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Choose a Package��6F   ��5      �� 5      .R�5   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5   &   �� ��60   �� *	PkgName+6K   5   #   5      5!      �� 5"      -   5         ��Name$ statusTextBlock��5"   9   $��1��6    $	��234��6-   $��27��6R   $
��Left=�6^   $��	150,0,0,0q�6z   $��20(�6�   $
��Bold"�6�   $�� ��6�   $	��Top=�6�   6�   �� 5#      $��2��6#   .��5$      �� $	��400��6%   $
��Left=�61   $��50 20q�6L   .+�5%      �� $��Edit Package��6$   $��Center=�6;   $��20(�6X   �� 5&      -   5         ��Name$ nameTextbox��5&   &    %  !MaterialDesignFloatingHintTextBox#��[  6;   $ Package Name��6v    �� TextWrapping$
 Wrap=�6�   $	��300��6�   $
��0 10q�6�   ��6�   ��  �� Path$ PackageName� �� Mode$ TwoWay=�6�   (  "System.Windows.Controls.DatePicker  5'      -   5        $��	startDate��5'   )      SelectedDate 	5/19/20206:   $ 
Start Date��6�   $	��300��6�   $
��0 10q�6�      Text 6S   �� $ PackageStart�$ TwoWay=�6�     5(      -   5        $��endDate��5(   )    	5/19/202068   $	��300��6   $ End Date��6�   $
��0 10q�6�    6Q   �� $ 
PackageEnd�$ TwoWay=�6�   �� 5)      -   5        $
 desc��5)   &   #��[  64   $ Description��6o   $
 Wrap=�6�   $	��300��6�   $
��0 10q�6�   ��6�   �� $ PackageDesc�$ TwoWay=�6�   �� 5*      -	   5        $��costTextbox��5*   �   $ 
Base Price��6&   $
 Wrap=�6�   #��[  6�   $	��300��6�   $
��0 10q�6�   ��6S   �� $ PackagePrice�$ TwoWay=�6   �� 5+      -
   5        $ image��5+   &   #��[  6e   $ Image Description��6�   $
 Wrap=�6�   $	��300��6�   $
��0 10q�6�   ��65   �� $ PackageImage�$ TwoWay=�6�   �� 5,      -   5        $ commissionTextbox��5,   &   #��[  6A   $ Agency Commision��6�   $
 Wrap=�6  $	��300��6$  $
��0 10q�60  ��6�   �� $ PackageCommission�$ TwoWay=�60  �� 5-      $��Bottom=�6)   $	��300��6D   $��0 20 0 0q�6P   .+�5.   "   �� -   5         ��Name$ submitButton��5.   )   $��Edit Package��6\   5/      50      51      52      53      54      55      56      