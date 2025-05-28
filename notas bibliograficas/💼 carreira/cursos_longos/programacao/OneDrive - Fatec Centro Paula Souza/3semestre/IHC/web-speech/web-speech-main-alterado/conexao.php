<?php
$servername = "localhost";
$username = "root";
$password = "";
$dbname = "db_ihc";

// Cria a conexão com o banco de dados
$con = mysqli_connect($servername, $username, $password, $dbname) or die("Falha na conexão: " . mysqli_connect_error());

