   M S B A M L   `   `   `  ����A  =WPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WPFAppWPFApp  5   	       WPFApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WPFApp     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.2.1465, Culture=neutral, PublicKeyToken=nullZ VMaterialDesignThemes.MahApps, Version=0.1.2.1465, Culture=neutral, PublicKeyToken=nullHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	     � Title$  WPF App��5	   	   $	��450��6   $	��800��6&   .��5
      � -   5        ���	#FFEEEEEE.+�5   
   �� $	��Top=�6   .+�5      � ���	#FF0069C0$��10��6*   5)      � 5+   
   $��	250 0 0 0q�6   .+�5,      � -   5         �Name$ GridPrincipal��5,      $��Center=�6*   $��Center=�6G   5-      � 5/   
   $	��250��6   $
��Left=�6   ���	#FF222222.+�50      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TrainsitionigContentSlide��50   2   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6U   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration 0:0:0.2.��51      � -   5        $ 
GridCursor��51      $��	0 100 0 0q�6+   ���	#FF0069C0$��10��6U   $
��Left=�6`   $��60��6{   $	��Top=�6�   52      �� 53      -   5         ��Name$ ListViewMenu��53      $��
0 100 0 70q�6-   
�������$��Champagne & Limousines)�6X   $��18(�6�    �� SelectedIndex$ 0��6�   .@�54      �� $��60��6   .��55      ��  �� Orientation$ 
Horizontal=�6!   .+�56      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Home=�62   $��30��6>   $��30��6I   $��Center=�6U   $��5q�6p   �� 57      $��Login��6$   $��17(�61   $��Center=�6?   $
��20 0q�6Z   58      59      �� 5:      $��60��6   .��5;      �� $ 
Horizontal=�6!   .+�5<        $ Globe=�62   $��30��6?   $��30��6J   $��Center=�6V   $��5q�6q   �� 5=      $��Packages List��6$   $��17(�69   $��Center=�6G   $
��20 0q�6b   5>      5?      �� 5@      $��60��6   .��5A      �� $ 
Horizontal=�6!   .+�5B        $
 Plus=�62   $��30��6>   $��30��6I   $��Center=�6U   $��5q�6p   �� 5C      $��Add New Package��6$   $��17(�6;   $��Center=�6I   $
��20 0q�6d   5D      5E      �� 5F      $��60��6   .��5G      �� $ 
Horizontal=�6!   .+�5H        $ AccountEdit=�62   $��30��6E   $��30��6P   $��Center=�6\   $��5q�6w   �� 5I      $��Edit Package��6$   $��17(�68   $��Center=�6F   $
��20 0q�6a   5J      5K      �� 5L      $��60��6   .��5M      �� $ 
Horizontal=�6!   .+�5N        $
 Cash=�62   $��30��6>   $��30��6I   $��Center=�6U   $��5q�6p   �� 5O      $��Products List��6$   $��17(�69   $��Center=�6G   $
��20 0q�6b   5P      5Q      �� 5R      $��60��6   .��5S      �� $ 
Horizontal=�6!   .+�5T        $ AccountStar=�62   $��30��6E   $��30��6P   $��Center=�6\   $��5q�6w   �� 5U      $��Add Product��6$   $��17(�67   $��Center=�6E   $
��20 0q�6`   5V      5W      5X      �� 5Y      $��Center=�6   $��0,21,0,0q�61   $��30(�6C   
�������$��Agents Portal��6d   $	��Top=�6|   $	��200��6�   �� 5Z      -   5         "  MaterialDesignRaisedDarkButton#���   5Z      $��Bottom=�6N   $
��Quit��6i   $��17(�6�   $��44��6�   6�   5[      5]      5^      