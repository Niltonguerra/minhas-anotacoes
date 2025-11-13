<?php
    include('conexao.php');
    
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>StarLanches</title>
    <link rel="stylesheet" style="text/css" href="style.css">
</head>
<body>
    <div class="navbar">
    <img src="img/logo.png" width="12%">
    <a href="index.php">Home</a>
    <a href="Sobre.php">Sobre</a>
    <a href="Cardapio.php">Cardápio</a>
    <?php
    
        echo '<a href="Logout.php" class="right">Logout</a>';
        echo '<a href="" class="right"></a>';
        echo '<a href="Carrinho.php" class="right"><img src="img/Cart.png"></a>';
        
            echo '<a href="Listagem.php" class="right">Lista</a>';
        

        
    
        echo '<a href="Login.php" class="right">Login</a>';
    
    ?>
</div>
<div class="star"><h1>StarLanches</h1>
</div>
</body>
</html>

