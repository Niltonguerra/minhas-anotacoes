<?php
include 'conexao.php';

if(isset($_POST ['busca_nome']) !="") {
    $sql = mysql_query("select * from tb_login where usuario 
                        like   '{$_POST['busca_nome']}%' order by usuario asc");

} else { 
    $sql= mysql_query ("select * from tb_login order by usuario asc");
}
?>


<html>
<body>
<center>
<form name="form1" method="POST" action="listagem.php">
    
   <th> Digite um usuario:
    <input type="text" name="busca_nome">
    <input type="submit" value="FILTRAR">
</form>

<table border="1" align="center">
    <tr>
        <th colspan="3" color="white" bgcolor="gray" > LISTAGEM DE CONTAS CADASTRADAS</th>

</th>
<tr>

    <th bgcolor="white"> Usuario </th>
    <th bgcolor="white"> Email </th>
    <th bgcolor="white"> Senha</th>

</tr>
<tr>
    <?php
        while($linha = mysql_fetch_assoc($sql)) {
            ?>
            <td align="center"><?php echo $linha["usuario"];?></td>
            <td align="center"><?php echo $linha["email"];?></td>
            <td align="center"><?php echo $linha["senha"];?></td>
            <tr>
    <?php }

            echo "<br>";
            echo "<center>";
            echo "<hr>";
            echo "<a href=\"login.php\">Retornar ao login </a>";
            echo "<hr>";
    ?>

        </table>
        </body>
        </html>



