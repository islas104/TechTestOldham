# Terraform AWS Environment Deployment

This Terraform project deploys an environment in AWS to host the [MyApp](https://github.com/islas104/TechTestOldham) application. It includes the necessary AWS resources such as VPC, EC2 instances, and security groups.

## Prerequisites

Before you begin, ensure you have the following prerequisites:

- [Terraform](https://www.terraform.io/downloads.html) installed on your local machine.
- AWS credentials configured on your machine with appropriate permissions.
- An SSH key pair for EC2 instances (e.g., `my-ec2-key.pem` and `my-ec2-key.pub`) generated and stored securely.

## Usage

1. Clone this repository to your local machine:

   ```bash
   git clone https://github.com/islas104/TechTestOldham-Terraform.git
   cd TechTestOldham-Terraform
   ```

2. Create a `terraform.tfvars` file in the root directory with your AWS credentials and any required variables:

   ```hcl
   aws_access_key = "YOUR_AWS_ACCESS_KEY"
   aws_secret_key = "YOUR_AWS_SECRET_KEY"
   region         = "us-west-2"
   ```

3. Initialize the Terraform project:

   ```bash
   terraform init
   ```

4. Preview the changes that Terraform will make:

   ```bash
   terraform plan
   ```

5. Apply the changes to create the AWS environment:

   ```bash
   terraform apply
   ```

6. After the deployment is complete, Terraform will output relevant information, such as the public IP address of the EC2 instances.

7. To destroy the environment when you're done, run:

   ```bash
   terraform destroy
   ```

## Inputs

- `aws_access_key` (string): Your AWS access key.
- `aws_secret_key` (string): Your AWS secret key.
- `region` (string): The AWS region where the environment will be deployed.

## Outputs

- `instance_public_ip` (list of strings): Public IP addresses of the EC2 instances.

## Contributing

Contributions to this Terraform project are welcome. Please follow the [contribution guidelines](CONTRIBUTING.md).

## License

This project is licensed under the [MIT License](LICENSE).
```

In this README.md file:

- Replace `"YOUR_AWS_ACCESS_KEY"` and `"YOUR_AWS_SECRET_KEY"` in the `terraform.tfvars` section with your actual AWS credentials.
- Customize the instructions for your specific use case and deployment.
- Add any additional sections or details that are relevant to your project.

Make sure to include any necessary links to the Terraform code repository, your application repository, and relevant documentation. This README provides a basic structure that you can expand upon to meet the specific needs of your project.