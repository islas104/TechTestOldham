# Configure the AWS provider
provider "aws" {
  region = "us-east-1"  # Set your desired AWS region
}

# Create a VPC
resource "aws_vpc" "my_vpc" {
  cidr_block = "10.0.0.0/16"
  enable_dns_support = true
  enable_dns_hostnames = true

  tags = {
    Name = "MyVPC"
  }
}

# Create a subnet within the VPC
resource "aws_subnet" "my_subnet" {
  vpc_id                  = aws_vpc.my_vpc.id
  cidr_block              = "10.0.0.0/24"
  availability_zone       = "us-east-1a"  # Set your desired availability zone
  map_public_ip_on_launch = true

  tags = {
    Name = "MySubnet"
  }
}

# Create a security group for the EC2 instance
resource "aws_security_group" "instance_sg" {
  name_prefix = "instance-"
  
  ingress {
    from_port   = 22  # SSH
    to_port     = 22
    protocol    = "tcp"
    cidr_blocks = ["0.0.0.0/0"]  # Allow SSH from anywhere
  }

  # Add more rules as needed

  vpc_id = aws_vpc.my_vpc.id
}

# Create an SSH key pair
resource "aws_key_pair" "my_key_pair" {
  key_name = "my-key-pair"

  public_key = file("~/.ssh/id_rsa.pub")  # Replace with your public key path
}

# Create an EC2 instance
resource "aws_instance" "my_instance" {
  ami           = "ami-0c55b159cbfafe1f0"  # Amazon Linux 2 AMI (adjust as needed)
  instance_type = "t2.micro"              # Instance type (adjust as needed)
  subnet_id     = aws_subnet.my_subnet.id
  key_name      = aws_key_pair.my_key_pair.key_name
  security_groups = [aws_security_group.instance_sg.name]

  tags = {
    Name = "MyEC2Instance"
  }
}
