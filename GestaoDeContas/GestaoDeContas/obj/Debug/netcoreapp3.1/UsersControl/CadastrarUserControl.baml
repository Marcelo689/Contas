   M S B A M L   `   `   `  ����I  EGestaoDeContas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:GestaoDeContas.UsersControlGestaoDeContas.UsersControl  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      6    0GestaoDeContas.UsersControl.CadastrarUserControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:GestaoDeContas.UsersControl     5      6sys&clr-namespace:System;assembly=mscorlib     5      .��5
      �   � ColumnDefinitions  5   
   �� 5      $��40 �6   �� 5      $	��200 �6   �� 5      $	��200 �6   �� 5      $��40 �6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��25 �6   �� 5      $��20 �6   �� 5      $��20 �6   �� 5      $��20 �6   �� 5      $��23 �6   �� 5      $��34 �6   �� 5      $��23 �6   �� 5      $��23 �6   �� 5      $��40 �6   .+�5   
   �� $��1��6   $��1��5      $�� Cadastro de Conta��5       $��Center=�5!      $��2��5"      �� 5#   
   $��2��6   $��1��5$      $��Nome da Conta��5%      �� 5&   
   $��3��6   $��1��5'      $��Preço��5(      �� 5)   
   $��4��6   $��1��5*      $��Necessidade��5+      �� 5,   
   $��5��6   $��1��5-      $��Data de Vencimento��5.      �� 50   
   $��2��6   $��2��51      ��52      �� *
Conta.Nome+�� 53   
   $��3��6   $��2��54      ��55      �� *Conta.Preco+�� 56   
   $��4��6   $��2��59       �� SelectedIndex 57      �� *Conta.Necessidade+ �� UpdateSourceTrigger$ PropertyChanged=���58      �� *ComboNecessidade+$ PropertyChanged=�59      (  "System.Windows.Controls.DatePicker  5:   
   -   5          Name$ 
DataAPagar��5<      $��5��5:      $��2��5;      
 �� Now   DisplayDate# Z 5=         SelectedDate 5>      �� *Conta.DataAPagar+ �� TargetNullValue# Z 5?      �� 5@   
   $��6��6   $��1��6#   .+�5A      �� $��	Parcelado��5B      �� 5C      	 d� 	IsChecked	 6   �� *
IsBoleto+5E      �� 5F   
   $��6��6   $��2��6"   .+�5G      �� $��Começa esse mês��5H      �� 5I      	 6   �� *ComecaNesseMes+5J      �� 5K   
   $��7��6   $��1��5L      $��Número de parcelas��5N      y�5M      �� *	isVisible+5N      �� 5O   
   $��7��6   $��2��5S       5P      �� *NumeroParcelas+$ PropertyChanged=���5Q      �� *
Parcelas+$ PropertyChanged=�y�5R      �� *	isVisible+5S      �� 5T   
   $��8��6   $��1��5U      $��Intervalo entre parcelas��5W      y�5V      �� *	isVisible+5W      �� 5X   
   $��8��6   $��2��5\      y�5Y      �� *	isVisible+ 5Z      �� *NumeroDeDiasEntreParcelas+$ PropertyChanged=���5[      �� *QuantidadeDeDias+$ PropertyChanged=�5\      �� 5^   
   $��9��6   $��10q�5_      $��1��5`      $��Center=�5a      $��2��5b      $��	Cadastrar��5c      ��5d      �� *CadastrarCommand+5e      5f      