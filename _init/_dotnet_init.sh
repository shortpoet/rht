################
#
##  Usage
#
##    set subspace to first arg
##    set class name to second arg
##    script checks for existence of dir before creating
#
################

# turn on error log
set -e

# set subspace to first arg
SUBSPACE=$1
# echo 
# echo "this subspace"
# echo $SUBSPACE
# echo 

# set class name to second arg
NAME=$2
# echo 
# echo "this subspace"
# echo $SUBSPACE
# echo 

# find parent dir
THISPATH=`realpath .`
# echo
# echo "this path"
# echo $THISPATH
# echo
PARENTPATH=`dirname "$THISPATH"`
# echo
# echo "parent path"
# echo $PARENTPATH
# echo

# set namespace variable based on grandparent dir of _init
NAMESPACE=`basename "$PARENTPATH"`
# echo
# echo "NAMESPACE"
# echo $NAMESPACE
# echo

# set outpath variable
OUTPATH=$PARENTPATH"/$SUBSPACE/"
# echo
# echo "out path"
# echo $OUTPATH
# echo

# make subspace dir if not exists
if [ ! -d "$OUTPATH" ]
  then
  mkdir $OUTPATH
  # create subspace c# class
  CLASS=$OUTPATH$NAME".cs"
  # echo
  # echo $CLASS
  # echo
  cp _dotnet_class_template.txt $CLASS

  # replace variables in class file
  perl -i -p -e "s/\\\$NAMESPACE/$NAMESPACE.$SUBSPACE/g" $CLASS
  perl -i -p -e "s/\\\$NAME/$NAME/g" $CLASS
fi
