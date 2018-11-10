

if ~(exist("data", "var") == 1)
    # https://octave.org/doc/v4.4.1/Including-File-Content.html
    # <include>Tests00Data.m</include>
    # addpath("./interactive-shells/matlab-octave/01-DarkVaderTests/Tests20180119Dataset01/");
    # source ("Tests00Data.m", "caller")
    # run("./Tests00Data.m")
    # Tests00Data
    file_path = fileparts(mfilename('fullpath'));
    file_path
    addpath(file_path);
    run("Tests00Data.m");
endif


disp ("==================================================================================")
# Arrange
tic ();
# Act
mean_arithmetic = mean_arithmetic = mean(data_jumps_defensive, "a");
elapsed_time = toc ();
# Assert
disp ("mean_arithmetic               = "), disp(mean_arithmetic)
disp ("              time [\u00B5s] = "), disp(elapsed_time * 1000000)
#assert(mean_arithmetic == 3.8)
disp ("==================================================================================")


disp ("==================================================================================")
# Arrange
tic ();
# Act
mean_geometric = mean(data_jumps_defensive, "g");
elapsed_time = toc ();
# Assert
disp ("mean_geometric               = "), disp(mean_geometric)
disp ("              time [\u00B5s] = "), disp(elapsed_time * 1000000)
#assert(mean_arithmetic == 3.8)
disp ("==================================================================================")


disp ("==================================================================================")
# Arrange
tic ();
# Act
mean_harmonic = mean(data_jumps_defensive, "h");
elapsed_time = toc ();
# Assert
disp ("mean_harmonic                = "), disp(mean_harmonic)
disp ("              time [\u00B5s] = "), disp(elapsed_time * 1000000)
#assert(mean_arithmetic == 3.8)
disp ("==================================================================================")


disp ("==================================================================================")
# Arrange
tic ();
# Act
mean_squared = meansq(data_jumps_defensive);
elapsed_time = toc ();
# Assert
disp ("mean_squared                 = "), disp(mean_squared)
disp ("              time [\u00B5s] = "), disp(elapsed_time * 1000000)
#assert(mean_arithmetic == 3.8)
disp ("==================================================================================")

disp ("==================================================================================")
# Arrange
tic ();
# Act
result_median = median(data_jumps_defensive);
elapsed_time = toc ();
# Assert
disp ("median                       = "), disp(result_median)
disp ("              time [\u00B5s] = "), disp(elapsed_time * 1000000)
#assert(mean_arithmetic == 3.8)
disp ("==================================================================================")


disp ("==================================================================================")
# Arrange
tic ();
# Act
[M, F, C] = mode(data_jumps_defensive);
elapsed_time = toc ();
# Assert
disp ("mode                         = "), disp(M)
disp ("F                            = "), disp(F)
disp ("C                            = "), disp(C)
disp ("              time [\u00B5s] = "), disp(elapsed_time * 1000000)
#assert(mean_arithmetic == 3.8)
disp ("==================================================================================")


disp ("==================================================================================")
# Arrange
tic ();
# Act
result_range = range(data_jumps_defensive);
elapsed_time = toc ();
# Assert
disp ("range                        = "), disp(result_range)
disp ("              time [\u00B5s] = "), disp(elapsed_time * 1000000)
#assert(mean_arithmetic == 3.8)
disp ("==================================================================================")

