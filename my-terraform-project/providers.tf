provider "aws" {
  region = "us-east-1"  # Change this to your desired AWS region

  # AWS credentials can be configured using environment variables, AWS CLI configuration, or IAM roles.
  # You can set AWS_ACCESS_KEY_ID and AWS_SECRET_ACCESS_KEY as environment variables if needed.
  # Alternatively, you can use IAM roles if you're running Terraform on an EC2 instance with an associated role.

  # Uncomment and configure the following if using static AWS access and secret keys:
  # access_key = "YOUR_AWS_ACCESS_KEY"
  # secret_key = "YOUR_AWS_SECRET_KEY"
}
