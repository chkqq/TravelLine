import "./Button.css";

type ButtonProps = {
    className: string;
    onClick: () => void;
    children: React.ReactNode;
  };
  
  function Button({ className, onClick, children }: ButtonProps) {
    return (
      <button className={`button ${className}`} onClick={onClick}>
        {children}
      </button>
    );
  }
  
  export default Button;