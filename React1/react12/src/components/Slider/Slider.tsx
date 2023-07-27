import "./Slider.css";
import React, { useState, ChangeEvent } from "react";

type SliderProps = {
  onChange: (value: number) => void;
  text: string; 
};

function Slider({ onChange, text }: SliderProps) {
  const [sliderValue, setSliderValue] = useState(1);

  const handleSliderChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    const value = parseInt(event.target.value);
    setSliderValue(value);
    onChange(value);
  };

  return (
    <div className="slider">    
      <input className="slider-input"
        type="range"
        min={1}
        max={5}
        step={1}
        value={sliderValue}
        onChange={handleSliderChange}
      />
      <output className="slider-output">{sliderValue}</output>
      <label className="slider-text">{text}</label>
    </div>
  );
}
export default Slider;