   M S B A M L   `   `   `  ����E  ALittleShop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:LittleShop.ViewLittleShop.View  5   	   m iSystem.Windows.Forms.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35�mclr-namespace:System.Windows.Forms.DataVisualization.Charting;assembly=System.Windows.Forms.DataVisualization/System.Windows.Forms.DataVisualization.Charting 5   	   &     LittleShop.View.MakeOrderWindows   5   	   ^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:LittleShop.View     5   	   }dvcmclr-namespace:System.Windows.Forms.DataVisualization.Charting;assembly=System.Windows.Forms.DataVisualization     5   	   -   5          � Title$  MakeOrderWindows��5
   	   $	��450��6"   $	��800��6/    � 	Resources 5         
Image.Drac  
Image.Barb  	Image.OMG  	Image.Por  	Image.Bob  Image.Devil  
Image.Luna  Image.Super��%D  &	        &	 �     &	 �     &	 x    &	 �    &	 u    &	 �    &	 r    �� 5   
   $m��gD:\Новая папка\Csharp\LittleShop\LittleShop\Resourses\Категории\Dolls\Draculaura.png��6#   �� 5   
   $i��cD:\Новая папка\Csharp\LittleShop\LittleShop\Resourses\Категории\Dolls\barbie.png��6#   �� 5   
   $f��`D:\Новая папка\Csharp\LittleShop\LittleShop\Resourses\Категории\Dolls\OMG.png��6"   �� 5   
   $l��fD:\Новая папка\Csharp\LittleShop\LittleShop\Resourses\Категории\Dolls\Porcelain.png��6"   �� 5   
   $i��cD:\Новая папка\Csharp\LittleShop\LittleShop\Resourses\Категории\FunkoPOP\Bob.png��6"   �� 5   
   $k��eD:\Новая папка\Csharp\LittleShop\LittleShop\Resourses\Категории\FunkoPOP\Devil.png��6$   �� 5   
   $j��dD:\Новая папка\Csharp\LittleShop\LittleShop\Resourses\Категории\FunkoPOP\Luna.png��6#   �� 5   
   $n��hD:\Новая папка\Csharp\LittleShop\LittleShop\Resourses\Категории\FunkoPOP\SuperMan.png��6$   5"      .��5#      �  � RowDefinitions 5$   
   �� 5%      $	��37* �6   �� 5&      $
��397* �6   .+�5)   
   � $��2��6    5*      �� 5+      $��50 �6    �� 5,      $��30 �6    �� 5-      $��* �6    �� 5.      $��30 �6    .+�54      � $��0��6   ���#08E8DE � ColumnDefinitions 55      �� 56      $��* �6'   �� 57      $��2* �6'   �� 58      $��* �6'   .+�5:      �� $��0��6   $Z��TD:\Новая Папка\Csharp\LittleShop\LittleShop\Resourses\Иконки\Ava.ico��6(   5;      �� 5<      $��1��6   $��Сделать заказ��6,   $��Center=�6A   $��Center=�6^   $��Comic Sans MS)�6y   $��18(�6�   5=      �� 5>      -   5        $��b_BackToMenu��5>   )   $��2��6   $��Stretch=�6=   $��Stretch=�6[   $��10q�6w   $$��Вернуться в меню��6�   $��Comic Sans MS)�6�   $��12(�6�   ���#F19CBB5?      5@      � 5B      $��1��6   
������� 5C      �� 5D      $	��110 �6'   �� 5E      $��20 �6'   �� 5F      $	��260 �6'   �� 5G      $	��260 �6'   �� 5H      $��* �6'   .+�5L      �� $��0��6   $(��"Товаров в корзине: ��6,   $
��Left=�6G   $��Center=�6b   $��Comic Sans MS)�6}   $��12(�6�   $��2��6�   $��16��6�   $	��113��6�   5M      �� 5N      -   5         ��Name$ tb_CartCurrent��5N   ,   $��1��6   $��0 ��6D   $
��Left=�6N   $��Center=�6i   $��Comic Sans MS)�6�   $��12(�6�   $��16��6�   $��11��6�   5O      �� 5P      -   5         ��Name$ b_ShCart��5P   )   $��4��6   $&�� Перейти в корзину��6;     Style_MakeOrderPages#��[ 6f   $��5,3,5,0q�6�   $��24��6�   $	��Top=�6�   �� 5R      -   5        $��tB_bank_Order��5R   �   $��2��6   $��Center=�6,   $
��Wrap=�6I   $��Баланс: ��6]   $��Center=�6m   $��Comic Sans MS)�6�   $��16(�6�   $	��160��6�   $��26��6�   6�   �� 5S      -   5        $��tB_orderpr_Order��5S   �   $��3��6   $��Center=�6,   $
��Wrap=�6I   $��Сумма заказа: ��6]   $��Center=�6s   $��Comic Sans MS)�6�   $��16(�6�   $	��160��6�   $��26��6�   6�   5U      � 5X      $��2��6    5Y      �� 5Z      $
��223* �6'   �� 5[      $	��12* �6'   �� 5\      $
��104* �6'   �� 5]      $
��369* �6'   �� 5^      $
��Auto �6'   �� 5_      $	��92* �6'    5b      �� 5c      $��* �6$   �� 5d      $��* �6$   .+�5�      ��  �� Orientation$ 
Horizontal=�6   $��1��66   $��
10,20,0,30q�6Y   $
��Left=�6m   $	��130��6�   $	��NaN��6�   ��6C   Z� .+�5�      �� $ Vertical=�6!   $��0��68   5�      7  1System.Windows.Forms.Integration.WindowsFormsHost  5�      $	��111��6=   $	��130��6J      
Background 6'   Z�    Child. 5�      ;  5System.Windows.Forms.DataVisualization.Charting.Chart  -   5        
chartSumma��[ WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"  System.Windows.Forms.Control	   Width$		 100��5�   8   
   Height$
 50��6D   5�      5�      �� 5�      -   5        $��list_Category��5�   �   $��
0,23,96,17q�6E   ���	#FF747780
�������$��3��6�   �� 5�      -	   5         ��Name$ ListBoxProducts��5�      
�������$	��208��5�      $	��502��6"   $
��Left=�6.   $��	39,47,0,0q�6I   $	��Top=�6\    J� RenderTransformOrigin$ 0.138,-0.325&�6t   $��2��6�   $��3��6�   $��2��6�   ��5�      �� 5�      .R�5�      �  5�   "   �� 5�   &   $��* �67   �� 5�   &   $��3* �67   �� 5�   &   $��* �67   .+�5�   "   �� $��0��6(   $��70��6:   $��70��6E   $
��Fill=�6p   $��0,0,20,0q�6   ��6R   ��  �� Path$ Photo�6   �� 5�   "   $��1��6-   $ Vertical=�6?   $��Center=�6V   .+�5�   &   �� $��10(�60   �� 5�   &   $�Название: ��6*    �� 5�   &   �6*   �� $
 Name�5�   '   �� 5�   &   $��10(�60   �� 5�   &   $�
Цена: ��6*    �� 5�   &   �6*   �� $
 Cost�5�   '   �� 5�   &   $��10(�60   �� 5�   &   $�Размер (см): ��6*    �� 5�   &   �6*   �� $ Widht�5�   '   5�   #   �� 5�   "   $ CreateOrder��6*   -
   5         	 Style_AddtoCart#��[	 5�   @   $��2��6i   $(��"Добавить в корзину��6y   $��Right=�6�   6�   5�      5�      5�      5�      � 5�      � 5�      $��4��6   ���#08E8DE 5�      �� 5�      $��* �6'   �� 5�      $��* �6'   .+�5�      �� $��0��6   $��©️Segeda_Nikita��6,   $
��Left=�6C   $��Center=�6^   $��Comic Sans MS)�6y   $��12(�6�   5�      �� 5�      $��1��6   $!��segeda.nikita2016@yandex.ru��6,   $��Right=�6O   $��Center=�6k   $��Comic Sans MS)�6�   $��10(�6�   5�      5�      5�      5�      5�      