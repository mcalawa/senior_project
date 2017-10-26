<!-- DOCTYPE -->
<!DOCTYPE html>
<html lang="en">
  <head>
    <title>CS 460 Homework 1</title>
    <meta charset="utf-8">
    <!-- Viewport Meta Tag -->
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/css/bootstrap.min.css" integrity="sha384-rwoIResjU2yc3z8GV/NPeZWAv56rSmLldC3R/AZzGRnGxQQKnKkoFVhFQhNUwEyJ" crossorigin="anonymous">
    <!-- Main Style Sheet -->
    <link rel="stylesheet" href="css/styles.css">
  </head>
  <body>
	
	
    <!-- YOUR CONTENT STARTS HERE -->
    
    <nav>
       <div class="navbar">
          <h1>CS 460 Homework 1</h1>
           <ul>
            <li><a href="index.html" class="active">Home</a></li>
            <li><a href="games.html">Games</a></li>
            <li><a href="anime.html">Anime</a></li>
            <li><a href="english.html">Words</a></li>
            <li><a href="https://mcalawa.github.io/senior_project/">Portfolio Home</a></li>
        </ul>
       </div>
    </nav>
    
    <div class="content">
       <?php 
           {{partial "content.html" | print | markdownify}} 
        ?>
    </div>
		
    <!-- YOUR CONTENT ENDS HERE -->


    <!-- JavaScript: placed at the end of the document so the pages load faster -->
		<!-- jQuery library -->
        <script src="https://code.jquery.com/jquery-3.1.1.slim.min.js" integrity="sha384-A7FZj7v+d/sdmMqp/nOQwliLvUsJfDHW+k9Omg/a/EheAdgtzNs3hpfag6Ed950n" crossorigin="anonymous"></script>

        <script src="https://cdnjs.cloudflare.com/ajax/libs/tether/1.4.0/js/tether.min.js" integrity="sha384-DztdAPBWPRXSA/3eYEEUWrWCy7G5KFbe8fFjk5JAIxUYHKkDx6Qin1DkWx51bBrb" crossorigin="anonymous"></script>

        <!-- Latest compiled and minified Bootstrap JavaScript -->
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-alpha.6/js/bootstrap.min.js" integrity="sha384-vBWWzlZJ8ea9aCX4pEW3rVHjgjt7zpkNpZk+02D9phzyeVkE+jo0ieGizqPLForn" crossorigin="anonymous"></script>
  </body>
</html>