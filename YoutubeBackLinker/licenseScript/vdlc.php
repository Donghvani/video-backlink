<?php  
    $saltedSerial = $_GET["s"];
    //$saltedSerial = "89613a14f3serial2e1e46269cf17f536e9e9cb99354b4";
    $ratioPercentage = $_GET["p"];
    //$ratioPercentage = 25;

    $serialAndDateTime = getSerialAndDateTime($saltedSerial, $ratioPercentage);
	//echo "request time sha1: ", json_encode($serialAndDateTime["dateTimeSha1"]), PHP_EOL; 
    
	$dateTimes = dts();
	//echo "dateTimes: ", json_encode($dateTimes), PHP_EOL;
	
	$validSha1s = getSha1s($dateTimes);
	//echo "valid Sha1s: ", json_encode($validSha1s), PHP_EOL; 
	
	echo json_encode(isValidRequest($serialAndDateTime["dateTimeSha1"], $validSha1s));

    function dts() {
        $dtNow = new DateTime("now", new DateTimeZone("UTC")); 
        
        $dtNowMinus1 = clone $dtNow;        
        $dtNowMinus1 ->modify('-1 minutes');        
        
        $dtNowPlus1 = clone $dtNow;  
        $dtNowPlus1 ->modify('+1 minutes');
        
        $result = array(
            "nowMinus1" => trimDateString($dtNowMinus1),
            "now" => trimDateString($dtNow),            
            "nowPlus1" => trimDateString($dtNowPlus1)
        );
        return $result;       
    }

    function trimDateString($dt){
        $dtTrim = json_encode($dt->format('Y-m-d H:i'));
        $dtTrim = substr($dtTrim, 1);
        $dtTrim = substr($dtTrim, 0, -1);
        return $dtTrim;
    }

    function getSha1s($dateTimes){
        $result = array(
            0 => sha1($dateTimes["nowMinus1"]),
            1 => sha1($dateTimes["now"]),           
            2 => sha1($dateTimes["nowPlus1"])
        );
        return $result;
    }

    function getSerialAndDateTime($saltedSerial, $ratioPercentage){
        $totalLenght = strlen($saltedSerial);
        $serialLength = $totalLenght - 40;
        $numberOfFirstChars = 40 * $ratioPercentage / 100;
        $numberOfSecondChars = 40 - $numberOfFirstChars;
        
        $sha1FirstPart = substr($saltedSerial, 0, $numberOfFirstChars);
        $sha1SecondPart = substr($saltedSerial, $numberOfFirstChars + $serialLength, $numberOfSecondChars);
        $serial = substr($saltedSerial, $numberOfFirstChars, $serialLength);
        
        $result = array(
            "dateTimeSha1" => $sha1FirstPart . $sha1SecondPart,
            "serial" => $serial                     
        );
        return $result; 
    }
	
	function isValidRequest($requestDateTimeSha1, $validSha1s){
		return in_array($requestDateTimeSha1, $validSha1s);
	}
?>