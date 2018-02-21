cmake_minimum_required(VERSION 3.0.0)

project(plugin)

set(CMAKE_CXX_FLAGS "-std=c++0x -O3 -fPIC -shared")
set(SRC plugin.cpp)

##plugin 
##-I
include_directories(. ) 

##-L
link_directories(.)

##library
add_library(${PROJECT_NAME} SHARED ${SRC})

##-l  do not need "-l"
target_link_libraries(${PROJECT_NAME} )
