<?php
header('Access-Control-Allow-Origin: *');  
header('Access-Control-Allow-Credentials: true');
header('Access-Control-Allow-Methods: GET, POST, PUT, DELETE, OPTIONS');
header("Access-Control-Allow-Headers: Origin, X-Requested-With, Content-Type, Accept");
    $path = $_POST['path'];
    $data = $_POST['data'];    
    file_put_contents($path,$data);
?>