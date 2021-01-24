<?php
header('Access-Control-Allow-Origin: *');  
header('Access-Control-Allow-Credentials: true');
header('Access-Control-Allow-Methods: GET, POST, PUT, DELETE, OPTIONS');
header("Access-Control-Allow-Headers: Origin, X-Requested-With, Content-Type, Accept");

$path = $_POST['path'] . '/';
$path = str_replace('\\', '/', $path);
if(file_exists($path) == false){
    echo "";
    return;
}
$folders = array();
$filelist = array();
$res = array();
$files = glob($path . "*");

foreach ($files as $file) {    
    $pin = (object) pathinfo($file);
    $pi = new stdClass;
    $pi->name = $pin->basename;
    if (is_dir($file)) {
        $pi->type = '0';
        $pi->ex = '';
        array_push($folders, $pi);
    } else {
        $pi->type = '1';
        $pi->ex = property_exists ($pin,'extension') ?$pin->extension:'';
        $pi->content = file_get_contents($file);
        array_push($filelist, $pi);
    }
}
sort($folders);
sort($filelist);
$res = array_merge($folders, $filelist);

echo (json_encode($res));
