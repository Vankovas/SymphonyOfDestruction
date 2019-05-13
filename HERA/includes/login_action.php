<?php

session_start();
$_SESSION["errorCheck"] = 10;

if (isset($_POST['login-btn'])){
    
    include 'connection.php';

    $uemail = mysqli_real_escape_string($conn, $_POST['useremail']);
    $upassword = mysqli_real_escape_string($conn, $_POST['psw']);
    
    $sql = "SELECT * FROM visitor WHERE email = '$uemail'; ";
    $result = mysqli_query($conn, $sql);
    $resultCheck = mysqli_num_rows($result);
    if($resultCheck < 1) {       
            
        $_SESSION["errorCheck"] = 1;
        header("Location: ../index.php");
        
       exit();
    } else {
        if ($row = mysqli_fetch_assoc($result)){
            //de-hashing pass
            $hashedPswCheck = password_verify($upassword, $row['password']);
            if($hashedPswCheck == false){
                
                    $_SESSION["errorCheck"] = 2;
                    header("Location: ../index.php");
                    exit();
                
            } elseif ($hashedPswCheck == true){
                
                $_SESSION['u_idnum'] = $row['userID'];
                $_SESSION['u_id'] = $row['email'];
                $_SESSION['u_firstname'] = $row['firstName'];
                $_SESSION['u_lastname'] = $row['lastName'];
                $_SESSION['u_password'] = $row['password'];
                
                header("Location: ../account.php");
                exit();
            }
        }
    }
    
} else {
    
    $_SESSION["errorCheck"] = 4;
    header("Location: ../index.php");
    exit();
}

?>