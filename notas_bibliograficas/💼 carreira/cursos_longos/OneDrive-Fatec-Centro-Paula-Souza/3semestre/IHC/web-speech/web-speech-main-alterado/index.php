<?php
include('conexao.php');

if(isset($_POST['cadastrar'])){
    $nome = $_POST['nome'];
    $data = $_POST['data'];
    $sexo = $_POST['sexo'];
    $cargo = $_POST['cargo'];
    
    $sql = "INSERT INTO funcionario (nome,data_nasc,sexo,cargo) VALUES ($nome, $data, $sexo, $cargo)";
    $res=mysqli_query($con,$sql);
    $linhas=mysqli_affected_rows($con);
    
    if($linhas>=1){
        echo "Salvo com sucesso";
    }else{
        echo "Erro ao salvar";
    }
    
}



?>







































<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Web Speech</title>
  




  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.9.0/css/bootstrap-datepicker.min.css">

  <link rel="stylesheet" href="./style.css" />


  <script src="./main.js" defer></script>

</head>


<body>


<div id="result">Clique no botão para falar!</div><br><br>


<form action="index.php" method="post">
<div class="caixa">
<label for="">Nome:</label><br>
<input type="text" name="nome" id="nome" value="seu nome"/>
<label id="btn1" class="btn"></label><br><br>
</div>


<div class="caixa">
<label for="">data de nascimento:</label><br>
<input type="text" class="form-control datepicker" id="data" name="data">
</div>

<div class="caixa">
<label for="">sexo:</label><br>
<input type="text" name="sexo" id="sexo" value="seu sexo"/>
<label id="btn3" class="btn"></label><br><br>
</div>

<div class="caixa">
<label for="">cargo:</label><br>
<input type="text" name="cargo" id="cargo" value="seu cargo"/>
<label id="btn4" class="btn"></label><br><br>
</div>

<button name="cadastrar"> enviar</button>

  <br><br><br><br>
</div>



</form>
</body>


<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.24.0/moment.min.js"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.9.0/js/bootstrap-datepicker.min.js"></script>
<script>
  // Inicializa o Bootstrap Datepicker
  $(document).ready(function(){
    $('.datepicker').datepicker({
      format: 'dd/mm/yyyy', // Define o formato da data
      language: 'pt-BR', // Define o idioma do datepicker
      autoclose: true // Fecha o datepicker após selecionar uma data
    });
  });
</script>



</html>

