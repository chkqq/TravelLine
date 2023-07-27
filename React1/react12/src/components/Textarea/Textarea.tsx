import "./Textarea.css";
import React, { useState, ChangeEvent } from "react";

type TextAreaProps = {
  onChange: (value: string) => void;
};

function TextArea({ onChange }: TextAreaProps) {
  const [textValue, setTextValue] = useState("");

  const handleTextChange = (event: ChangeEvent<HTMLTextAreaElement>) => {
    const value = event.target.value;
    setTextValue(value);
    onChange(value);
  };

  return (
    <div>
      <textarea
        className="text-area"
        cols={44}
        rows={6}
        value={textValue}
        onChange={handleTextChange}
        placeholder="What could we improve?"
      />
    </div>
  );
}

export default TextArea;