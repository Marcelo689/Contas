   M S B A M L   `   `   `  ����I  EGestaoDeContas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:GestaoDeContas.UsersControlGestaoDeContas.UsersControl  5      E'clr-namespace:GestaoDeContas.ConvertersGestaoDeContas.Converters  5      6    0GestaoDeContas.UsersControl.PesquisarUserControl   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:GestaoDeContas.UsersControl     5      =	converter'clr-namespace:GestaoDeContas.Converters     5      $��13(�5	        � 	Resources  5      4   .GestaoDeContas.Converters.NecessidadeConverter   Necessidade6   0GestaoDeContas.Converters.SituacaoContaConverter  Situacao��%:   &	        &	        5   
   6)     5   
   6+   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $��40 �6   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��40 �6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��25 �6   �� 5      $��45 �6   �� 5      $��25 �6   �� 5      $��40 �6   �� 5      �� 5       $��40 �6   .+�5#   
   �� $��5��6   $
��auto��5$      $��1��5%      $��1��5&       �� Orientation$ 
Horizontal=�5'      .+�5(      �� $
��Nome��6   $��0,2,4,0q�6$   �� 5)      $	��100��6   $��0,2,4,0q�5*      ��5+      �� *FiltrosConta.Nome+�� 5,      
�������$ 
Horizontal=�6+   .+�5-      �� $��0,2,4,2q�6   $��	Preço de��5.      �� 5/      -   5         ��Name$ TextBoxPrecoI��51      $��0,2,4,2q�5/      $��70��50      ��53      �� *FiltrosConta.PrecoI+ �� StringFormat$ N2���� 54      $��0,2,4,0q�6   $��à��55      �� 56      -   5        $ TextBoxPrecoF��58      $��70��56      $��0,2,4,2q�57      ��5:      �� *FiltrosConta.PrecoF+$ N2��5;      �� 5<      $ 
Horizontal=�6   
�����_�$��4,0,0,0q�6I   .+�5=      �� $��0,2,4,2q�6   $��Data Vencimento de��6-   (  "System.Windows.Controls.DatePicker  5>      $��0,2,4,2q�6   $	��100��5?      $��25��5@         SelectedDate 5A      �� *FiltrosConta.DataAPagarI+�� 5B      $��0,2,4,2q�6   $��à��6-     5C      $��0,2,4,2q�6   $	��100��5D      $��25��5E       5F      �� *FiltrosConta.DataAPagarF+5G      5H      �� 5J   
   $��5��6   $
��auto��5K      $��10q�5L      $��2��5M      $��1��5N      $ 
Horizontal=�5O      .+�5P      �� $��Situacao��6   $��0,2,4,0q�6(   �� 5Q      -   5         ��Name$ comboSituacao��5T      $	��150��5Q      $��20��5R      $��0,2,4,0q�5S       �� AlternationCount$ 3��5U      	 �� SelectedIndex	 5V      �� *FiltrosConta.Situacao+��5W      �� *ComboSituacao+�� 5X      $��Necessidade��6   $��0,2,4,0q�6+   �� 5Y      -   5        $ comboNecessidade��5\      $	��150��5Y      $��0,2,4,0q�5Z      $��20��5[      $ 3��5]      	 5^      �� *FiltrosConta.Necessidade+��5_      �� *ComboNecessidade+5`      �� 5a   
   $ 
Horizontal=�6   
�����_�$��3��5c      $
��Left=�5d      $��1��5e      $��5��5f      .+�5h      �� $��0,2,4,2q�6   $��Data Finalização de��5i        5j      $��0,2,4,2q�6   $	��100��5k      $��25��5l       5m      �� *FiltrosConta.DataFinalizacaoI+�� 5n      $��0,2,4,2q�6   $��à��5o        5p      $��0,2,4,2q�6   $��25��5q      $	��100��5r       5s      �� *FiltrosConta.DataFinalizacaoF+�� 5t      $ 
Horizontal=�6   $��45,0,0,0q�5u      
�����_�.+�5w      �� $��0,2,4,2q�6   $��Data Cadastro de��5x        5y      $��0,2,4,2q�6   $	��100��5z      $��25��5{       5|      �� *FiltrosConta.CadastroI+�� 5}      $��0,2,4,2q�6   $��à��5~        5      $��0,2,4,2q�6   $��25��5�      $	��100��5�       5�      �� *FiltrosConta.CadastroF+5�      5�      �� 5�   
   
 �� CornerRadius$
 20��6   $��10q�5�      $��4��5�      $��3��5�      ._�5�      �� 
������$��Filtrar��5�      ��5�      �� *FiltrarCommand+5�      &   System.Windows.Controls.DataGrid  5�   
   $��5��6   $��5��6       AutoGenerateColumns$ False��5�         
IsReadOnly$
 True��5�      $��1��5�      ��5�      �� *Contas+ �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header$
 Nome��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Nome+  5�      $ Preco��6%    64   �� *Preco+$ N2��  5�      $ Data Vencimento��6%    6>   �� *
DataAPagar+$ {0:dd.MM.yy}��  5�      $ Necessidade��6%    6:   �� *Necessidade+ �� 	Converter# [    5�      $ 
Situação��6%    67   �� *
Situacao+# [ 4  .System.Windows.Controls.DataGridTemplateColumn  5�         CellTemplate 5�      �� 5�      .R�5�      �� $��Liquidar��6&   
��� �|���5�   &   �� *Id+��5�   &   �� *DataContext.LiquidarCommand+ �� RelativeSource ��  �� AncestorType"  5�      5�        5�       5�      �� 5�      .R�5�      �� $��	Atualizar��6&   
����� ���5�   &   �� *Id+��5�   &   �� *DataContext.EditarCommand+ �� "  5�      5�        5�       5�      �� 5�      .R�5�      �� $��Deletar��6&   
���  ����5�   &   �� *Id+��5�   &   �� *DataContext.DeletarCommand+ �� "  5�      5�      5�      �� 5�   
   $��6��6   $��7��6!   $��Center=�65   �� 5�      $�Total da lista = ��6    �� 5�      �6   �� *Total+$ N2��5�      5�      5�      