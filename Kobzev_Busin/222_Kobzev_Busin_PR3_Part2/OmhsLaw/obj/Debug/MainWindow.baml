   M S B A M L   `   `   `  ����B  >OmhsLaw, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:OmhsLawOmhsLaw  5   	       OmhsLaw.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:OmhsLaw     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��800��6)    � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $ 
Style.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6"    �� Orientation$ Vertical=�62   $��20,10,10,10q�6I   .+�5      �� -   5        $��InputLabel1��5      $(��"Введите значение 1:��6+   $��14(�6F   $��0,0,0,5q�6T   �� 5      -   5        $��InputField1��5      $	��200��6)   $��30��65   $��0,0,0,10q�6A   �� 5       -   5        $��InputLabel2��5       $(��"Введите значение 2:��6+   $��14(�6F   $��0,0,0,5q�6T   �� 5!      -   5        $��InputField2��5!      $	��200��6)   $��30��65   $��0,0,0,10q�6A   5"      �� 5$   
   $��2��6   $��1��6&   $ Vertical=�66   $��10,10,20,10q�6M   .+�5%      	� -   5        $��CurrentRadioButton��5%      $��Сила тока (I)��64    	� 	GroupName$ CalculationType��6L   $��0,0,0,10q�6h   6z   	� 5&      -   5        $��VoltageRadioButton��5&      $��Напряжение (U)��64   $ CalculationType��6M   $��0,0,0,10q�6i   6{   	� 5'      -   5        $��ResistanceRadioButton��5'      $$��Сопротивление (R)��67   $ CalculationType��6S   $��0,0,0,10q�6o   6�   5(      �� 5*   
   $��1��6   $��2��6"   $ Vertical=�66   $��Center=�6M   $	��Top=�6j   $��0,10,0,0q�6�   .+�5+      �� -   5        $��CalculateButton��5+      $��Вычислить��6-   $	��150��6A   $��40��6M   $��0,0,0,10q�6w   �� 5,      -	   5        $��ResultLabel��5,      $��Результат:��6+   $��16(�6=   $��Center=�6K   �� 5-      -
   5        $��ResultValue��5-      $�� ��6+   $��18(�63   $
��Bold"�6A   
����  �$��Center=�6e   5.      5/      50      