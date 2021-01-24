<?php
    $path = "C:/Users";
    $sub = "/AppData/Roaming/Code/User/snippets";
    $files = glob($path.'/*');    
    foreach ($files as $file) {        
        if(is_dir($file)){
            $snppath = $file.$sub;
            if(file_exists($snppath)){
                echo $snppath;
                return;
            }            
        }
    }
?>