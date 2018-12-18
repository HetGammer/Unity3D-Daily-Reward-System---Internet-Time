<?php
 
date_default_timezone_set('Etc/UTC');
$currenttime = date("m-d-Y H:i:s");
list($ddd,$ttt) = explode(' ',$currenttime);
echo "\n$ddd/$ttt\n";

?>

